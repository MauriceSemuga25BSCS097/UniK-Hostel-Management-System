Imports System.Drawing
Imports System.Windows.Forms
Public Class ComplaintsForm
    Private _engine As CrudEngine

    Public Sub New()
        InitializeComponent()
        Theme.MakeEmbedded(Me)
    End Sub

    Private Sub ComplaintsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _engine = New CrudEngine("Student Complaints", "Complaints", "SELECT c.Id, s.RegNo AS [Reg No], s.FullName AS Student, c.Category, c.Subject, c.DateLodged AS [Lodged], c.Status FROM Complaints c JOIN Students s ON s.Id = c.StudentId ORDER BY c.Id DESC", dgv, txtSearch, lblMode, lblCount)
        _engine.Bind("StudentId", "Student", cboStudentId, True, "", Rules.StudentLk)
        _engine.Bind("Category", "Category", cboCategory, True)
        _engine.Bind("Subject", "Subject", txtSubject, True)
        _engine.Bind("Details", "Details", txtDetails)
        _engine.Bind("DateLodged", "Date Lodged", dtpDateLodged)
        _engine.Bind("Status", "Status", cboStatus, True)
        _engine.Bind("Resolution", "Resolution / Action Taken", txtResolution)
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
