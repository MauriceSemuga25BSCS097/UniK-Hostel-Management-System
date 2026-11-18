Imports System.Drawing
Imports System.Windows.Forms
Public Class ExeatForm
    Private _engine As CrudEngine

    Public Sub New()
        InitializeComponent()
        Theme.MakeEmbedded(Me)
    End Sub

    Private Sub ExeatForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _engine = New CrudEngine("Leave / Exeat Permissions", "Exeat", "SELECT e.Id, s.RegNo AS [Reg No], s.FullName AS Student, e.Destination, e.DateOut AS [Leaving], e.ExpectedReturn AS [Expected Return], e.ActualReturn AS [Returned On], e.Status FROM Exeat e JOIN Students s ON s.Id = e.StudentId ORDER BY e.Id DESC", dgv, txtSearch, lblMode, lblCount)
        _engine.Bind("StudentId", "Student", cboStudentId, True, "", Rules.StudentLk)
        _engine.Bind("Reason", "Reason", txtReason, True)
        _engine.Bind("Destination", "Destination", txtDestination)
        _engine.Bind("DateOut", "Date Leaving", dtpDateOut)
        _engine.Bind("ExpectedReturn", "Expected Return", dtpExpectedReturn)
        _engine.Bind("ActualReturn", "Actual Return", dtpActualReturn)
        _engine.Bind("Status", "Status", cboStatus, True)
        _engine.Bind("ApprovedBy", "Approved By", txtApprovedBy, False, "{user}")
        _engine.BeforeSave = AddressOf Rules.ExeatCheck
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
