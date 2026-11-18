Imports System.Drawing
Imports System.Windows.Forms
Public Class ApplicationsForm
    Private _engine As CrudEngine

    Public Sub New()
        InitializeComponent()
        Theme.MakeEmbedded(Me)
    End Sub

    Private Sub ApplicationsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _engine = New CrudEngine("Room Applications", "Applications", "SELECT a.Id, s.RegNo AS [Reg No], s.FullName AS Student, IFNULL(h.Name,'Any') AS [Preferred Hostel], a.PreferredRoomType AS [Room Type], a.Semester, a.AcademicYear AS [Academic Year], a.DateApplied AS [Applied], a.Status FROM Applications a JOIN Students s ON s.Id = a.StudentId LEFT JOIN Hostels h ON h.Id = a.HostelId ORDER BY a.Id DESC", dgv, txtSearch, lblMode, lblCount)
        _engine.Bind("StudentId", "Student", cboStudentId, True, "", Rules.StudentLk)
        _engine.Bind("HostelId", "Preferred Hostel", cboHostelId, False, "", Rules.HostelAnyLk)
        _engine.Bind("PreferredRoomType", "Preferred Room Type", cboPreferredRoomType, True)
        _engine.Bind("Semester", "Semester", cboSemester, True)
        _engine.Bind("AcademicYear", "Academic Year", txtAcademicYear, True, "{year}")
        _engine.Bind("DateApplied", "Date Applied", dtpDateApplied)
        _engine.Bind("Status", "Status", cboStatus, True)
        _engine.Bind("Remarks", "Remarks", txtRemarks)
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
