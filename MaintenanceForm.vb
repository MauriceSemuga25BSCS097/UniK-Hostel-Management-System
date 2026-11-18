Imports System.Drawing
Imports System.Windows.Forms
Public Class MaintenanceForm
    Private _engine As CrudEngine

    Public Sub New()
        InitializeComponent()
        Theme.MakeEmbedded(Me)
    End Sub

    Private Sub MaintenanceForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _engine = New CrudEngine("Maintenance & Repairs", "Maintenance", "SELECT m.Id, h.Name AS Hostel, IFNULL(r.RoomNo,'-') AS Room, m.Category, m.Issue, m.Priority, m.DateReported AS [Reported], m.AssignedTo AS [Assigned To], m.Status, m.Cost FROM Maintenance m JOIN Hostels h ON h.Id = m.HostelId LEFT JOIN Rooms r ON r.Id = m.RoomId ORDER BY m.Id DESC", dgv, txtSearch, lblMode, lblCount)
        _engine.Bind("HostelId", "Hostel", cboHostelId, True, "", Rules.HostelLk)
        _engine.Bind("RoomId", "Room (if specific)", cboRoomId, False, "", Rules.RoomNoneLk)
        _engine.Bind("Category", "Category", cboCategory, True)
        _engine.Bind("Issue", "Issue Description", txtIssue, True)
        _engine.Bind("Priority", "Priority", cboPriority, True)
        _engine.Bind("ReportedBy", "Reported By", txtReportedBy, False, "{user}")
        _engine.Bind("DateReported", "Date Reported", dtpDateReported)
        _engine.Bind("AssignedTo", "Assigned To", txtAssignedTo)
        _engine.Bind("Status", "Status", cboStatus, True)
        _engine.Bind("DateResolved", "Date Resolved", dtpDateResolved)
        _engine.Bind("Cost", "Repair Cost (UGX)", numCost)
        _engine.BeforeSave = AddressOf Rules.MaintenanceCheck
        _engine.Start()
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        _engine.ExportCsv()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        _engine.Refresh()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        _engine.Save()
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        _engine.NewRecord()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        _engine.DeleteSelected()
    End Sub
End Class
