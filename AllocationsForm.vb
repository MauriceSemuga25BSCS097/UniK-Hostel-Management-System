Imports System.Drawing
Imports System.Windows.Forms
Public Class AllocationsForm
    Private _engine As CrudEngine

    Public Sub New()
        InitializeComponent()
        Theme.MakeEmbedded(Me)
    End Sub

    Private Sub AllocationsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _engine = New CrudEngine("Room Allocation / Check-in / Check-out", "Allocations", "SELECT a.Id, s.RegNo AS [Reg No], s.FullName AS Student, h.Name AS Hostel, r.RoomNo AS Room, a.BedNo AS Bed, a.Semester, a.AcademicYear AS [Academic Year], a.CheckInDate AS [Check In], a.CheckOutDate AS [Check Out], a.Status FROM Allocations a JOIN Students s ON s.Id = a.StudentId JOIN Rooms r ON r.Id = a.RoomId JOIN Hostels h ON h.Id = r.HostelId ORDER BY a.Id DESC", dgv, txtSearch, lblMode, lblCount)
        _engine.Bind("StudentId", "Student", cboStudentId, True, "", Rules.StudentLk)
        _engine.Bind("RoomId", "Room", cboRoomId, True, "", Rules.RoomLk)
        _engine.Bind("BedNo", "Bed Number (optional)", txtBedNo)
        _engine.Bind("Semester", "Semester", cboSemester, True)
        _engine.Bind("AcademicYear", "Academic Year", txtAcademicYear, True, "{year}")
        _engine.Bind("CheckInDate", "Check-in Date", dtpCheckInDate)
        _engine.Bind("CheckOutDate", "Check-out Date", dtpCheckOutDate)
        _engine.Bind("Status", "Status", cboStatus, True)
        _engine.Bind("Remarks", "Remarks", txtRemarks)
        _engine.BeforeSave = AddressOf Rules.AllocationCheck
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
