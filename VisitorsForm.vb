Imports System.Drawing
Imports System.Windows.Forms
Public Class VisitorsForm
    Private _engine As CrudEngine

    Public Sub New()
        InitializeComponent()
        Theme.MakeEmbedded(Me)
    End Sub

    Private Sub VisitorsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _engine = New CrudEngine("Visitors Log", "Visitors", "SELECT v.Id, v.VisitDate AS [Date], v.VisitorName AS Visitor, v.IDNumber AS [ID No], s.FullName AS [Visiting], v.Purpose, v.TimeIn AS [In], v.TimeOut AS [Out], CASE WHEN v.TimeOut = '' OR v.TimeOut IS NULL THEN 'Inside' ELSE 'Left' END AS Status FROM Visitors v JOIN Students s ON s.Id = v.StudentId ORDER BY v.Id DESC", dgv, txtSearch, lblMode, lblCount)
        _engine.Bind("VisitorName", "Visitor Name", txtVisitorName, True)
        _engine.Bind("IDNumber", "ID / Passport No.", txtIDNumber)
        _engine.Bind("Phone", "Visitor Phone", txtPhone)
        _engine.Bind("StudentId", "Student Visited", cboStudentId, True, "", Rules.StudentLk)
        _engine.Bind("Purpose", "Purpose of Visit", txtPurpose)
        _engine.Bind("VisitDate", "Date", dtpVisitDate)
        _engine.Bind("TimeIn", "Time In (HH:mm)", txtTimeIn, False, "{now}")
        _engine.Bind("TimeOut", "Time Out (HH:mm) - fill when visitor leaves", txtTimeOut)
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
