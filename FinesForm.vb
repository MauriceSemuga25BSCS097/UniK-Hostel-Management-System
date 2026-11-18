Imports System.Drawing
Imports System.Windows.Forms
Public Class FinesForm
    Private _engine As CrudEngine

    Public Sub New()
        InitializeComponent()
        Theme.MakeEmbedded(Me)
    End Sub

    Private Sub FinesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _engine = New CrudEngine("Fines & Damages", "Fines", "SELECT f.Id, s.RegNo AS [Reg No], s.FullName AS Student, f.Reason, f.Amount, f.DateIssued AS [Issued], f.Status FROM Fines f JOIN Students s ON s.Id = f.StudentId ORDER BY f.Id DESC", dgv, txtSearch, lblMode, lblCount)
        _engine.Bind("StudentId", "Student", cboStudentId, True, "", Rules.StudentLk)
        _engine.Bind("Reason", "Reason (e.g. broken window)", txtReason, True)
        _engine.Bind("Amount", "Amount (UGX)", numAmount, True)
        _engine.Bind("DateIssued", "Date Issued", dtpDateIssued)
        _engine.Bind("Status", "Status", cboStatus, True)
        _engine.Bind("Remarks", "Remarks", txtRemarks)
        _engine.BeforeSave = AddressOf Rules.FineCheck
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
