Imports System.Drawing
Imports System.Windows.Forms
Imports System.Data

Public Class ReportsForm
    Private ReadOnly _reports As New Dictionary(Of String, String)
    Private _dt As DataTable
    Private _name As String = "Report"

    Public Sub New()
        InitializeComponent()
        Theme.MakeEmbedded(Me)
    End Sub

    Private Sub ReportsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Theme.StyleGrid(dgvReport)
        DefineReports()
        For Each k As String In _reports.Keys
            cboReports.Items.Add(k)
        Next
        If cboReports.Items.Count > 0 Then cboReports.SelectedIndex = 0
    End Sub

    Private Sub cboReports_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboReports.SelectedIndexChanged
        RunReport()
    End Sub

    Private Sub btnRun_Click(sender As Object, e As EventArgs) Handles btnRun.Click
        RunReport()
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        If _dt Is Nothing OrElse _dt.Rows.Count = 0 Then
            MessageBox.Show("Run a report with results first.", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Theme.ExportCsv(_dt, _name)
        End If
    End Sub

    Private Sub RunReport()
        If cboReports.SelectedItem Is Nothing Then Return
        _name = CStr(cboReports.SelectedItem)
        Try
            _dt = Db.Query(_reports(_name))
            dgvReport.DataSource = _dt
            lblStatus.Text = "  " & _dt.Rows.Count & " row(s)  -  " & _name
        Catch ex As Exception
            MessageBox.Show("Could not run report: " & ex.Message, "Reports", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub DefineReports()
        _reports("Hostel occupancy summary") =
            "SELECT Hostel, Type, Beds, Occupied, Beds - Occupied AS Available, CASE WHEN Beds = 0 THEN 0 ELSE ROUND(100.0 * Occupied / Beds, 1) END AS [Occupancy %] FROM (" &
            "SELECT h.Name AS Hostel, h.Type AS Type, IFNULL((SELECT SUM(r.Capacity) FROM Rooms r WHERE r.HostelId = h.Id), 0) AS Beds, " &
            "(SELECT COUNT(*) FROM Allocations a JOIN Rooms r2 ON r2.Id = a.RoomId WHERE r2.HostelId = h.Id AND a.Status = 'Active') AS Occupied FROM Hostels h) ORDER BY Hostel"

        _reports("Students currently in hostels") =
            "SELECT s.RegNo AS [Reg No], s.FullName AS Student, s.Gender, s.Phone, h.Name AS Hostel, r.RoomNo AS Room, a.BedNo AS Bed, a.CheckInDate AS [Check In] " &
            "FROM Allocations a JOIN Students s ON s.Id = a.StudentId JOIN Rooms r ON r.Id = a.RoomId JOIN Hostels h ON h.Id = r.HostelId " &
            "WHERE a.Status = 'Active' ORDER BY h.Name, r.RoomNo"

        _reports("Hostel fee balances (current residents)") =
            "SELECT *, Fee - Paid AS Balance FROM (SELECT s.RegNo AS [Reg No], s.FullName AS Student, h.Name AS Hostel, r.RoomNo AS Room, a.Semester AS Semester, a.AcademicYear AS [Academic Year], r.FeePerSemester AS Fee, " &
            "IFNULL((SELECT SUM(p.Amount) FROM Payments p WHERE p.StudentId = a.StudentId AND p.Semester = a.Semester AND p.AcademicYear = a.AcademicYear AND p.Purpose = 'Hostel Fee'), 0) AS Paid " &
            "FROM Allocations a JOIN Students s ON s.Id = a.StudentId JOIN Rooms r ON r.Id = a.RoomId JOIN Hostels h ON h.Id = r.HostelId WHERE a.Status = 'Active') ORDER BY Balance DESC"

        _reports("Payments this month") =
            "SELECT p.ReceiptNo AS [Receipt No], s.RegNo AS [Reg No], s.FullName AS Student, p.Purpose, p.Amount, p.PayDate AS [Date], p.Method, p.ReceivedBy AS [Received By] " &
            "FROM Payments p JOIN Students s ON s.Id = p.StudentId WHERE substr(p.PayDate,1,7) = strftime('%Y-%m','now','localtime') ORDER BY p.PayDate DESC"

        _reports("Payments by method") =
            "SELECT Method, COUNT(*) AS Transactions, SUM(Amount) AS Total FROM Payments GROUP BY Method ORDER BY Total DESC"

        _reports("Revenue by academic year and semester") =
            "SELECT AcademicYear AS [Academic Year], Semester, Purpose, COUNT(*) AS Transactions, SUM(Amount) AS Total FROM Payments GROUP BY AcademicYear, Semester, Purpose ORDER BY AcademicYear DESC, Semester"

        _reports("Available rooms and free beds") =
            "SELECT h.Name AS Hostel, h.Type AS [Hostel Type], r.RoomNo AS Room, r.RoomType AS [Room Type], r.Capacity, " &
            "r.Capacity - (SELECT COUNT(*) FROM Allocations a WHERE a.RoomId = r.Id AND a.Status = 'Active') AS [Free Beds], r.FeePerSemester AS Fee " &
            "FROM Rooms r JOIN Hostels h ON h.Id = r.HostelId WHERE r.Status = 'Available' AND r.Capacity > (SELECT COUNT(*) FROM Allocations a WHERE a.RoomId = r.Id AND a.Status = 'Active') ORDER BY h.Name, r.RoomNo"

        _reports("Pending room applications") =
            "SELECT s.RegNo AS [Reg No], s.FullName AS Student, s.Gender, a.PreferredRoomType AS [Room Type], a.Semester, a.AcademicYear AS [Academic Year], a.DateApplied AS Applied " &
            "FROM Applications a JOIN Students s ON s.Id = a.StudentId WHERE a.Status IN ('Pending','Waitlist') ORDER BY a.DateApplied"

        _reports("Unpaid fines and damages") =
            "SELECT s.RegNo AS [Reg No], s.FullName AS Student, f.Reason, f.Amount, f.DateIssued AS Issued FROM Fines f JOIN Students s ON s.Id = f.StudentId WHERE f.Status = 'Unpaid' ORDER BY f.DateIssued"

        _reports("Open maintenance requests") =
            "SELECT h.Name AS Hostel, IFNULL(r.RoomNo,'-') AS Room, m.Category, m.Issue, m.Priority, m.DateReported AS Reported, m.AssignedTo AS [Assigned To], m.Status " &
            "FROM Maintenance m JOIN Hostels h ON h.Id = m.HostelId LEFT JOIN Rooms r ON r.Id = m.RoomId WHERE m.Status <> 'Resolved' ORDER BY m.Priority, m.DateReported"

        _reports("Visitors today") =
            "SELECT v.VisitorName AS Visitor, v.IDNumber AS [ID No], v.Phone, s.FullName AS [Visiting], v.Purpose, v.TimeIn AS [In], v.TimeOut AS [Out] " &
            "FROM Visitors v JOIN Students s ON s.Id = v.StudentId WHERE v.VisitDate = date('now','localtime') ORDER BY v.TimeIn"

        _reports("Overdue exeat returns") =
            "SELECT s.RegNo AS [Reg No], s.FullName AS Student, s.Phone, e.Destination, e.DateOut AS [Left On], e.ExpectedReturn AS [Expected Return] " &
            "FROM Exeat e JOIN Students s ON s.Id = e.StudentId WHERE e.Status = 'Approved' AND (e.ActualReturn = '' OR e.ActualReturn IS NULL) AND e.ExpectedReturn < date('now','localtime') ORDER BY e.ExpectedReturn"

        _reports("Open complaints") =
            "SELECT s.RegNo AS [Reg No], s.FullName AS Student, c.Category, c.Subject, c.DateLodged AS Lodged, c.Status FROM Complaints c JOIN Students s ON s.Id = c.StudentId WHERE c.Status IN ('Open','Under Review') ORDER BY c.DateLodged"

        _reports("Inventory in poor or damaged condition") =
            "SELECT i.ItemName AS Item, i.Category, h.Name AS Hostel, IFNULL(r.RoomNo,'-') AS Room, i.Quantity, i.ItemCondition AS Condition " &
            "FROM Inventory i JOIN Hostels h ON h.Id = i.HostelId LEFT JOIN Rooms r ON r.Id = i.RoomId WHERE i.ItemCondition IN ('Poor','Damaged') ORDER BY h.Name"
    End Sub
End Class
