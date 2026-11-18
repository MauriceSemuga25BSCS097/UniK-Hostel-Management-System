Imports System.Drawing
Imports System.Windows.Forms
Public Class UsersForm
    Private _engine As CrudEngine

    Public Sub New()
        InitializeComponent()
        Theme.MakeEmbedded(Me)
    End Sub

    Private Sub UsersForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _engine = New CrudEngine("System Users", "Users", "SELECT Id, Username, FullName AS [Full Name], Role, Status FROM Users ORDER BY Username", dgv, txtSearch, lblMode, lblCount)
        _engine.Bind("Username", "Username", txtUsername, True)
        _engine.Bind("PasswordHash", "Password (leave blank to keep current)", txtPasswordHash, True)
        _engine.Bind("FullName", "Full Name", txtFullName, True)
        _engine.Bind("Role", "Role", cboRole, True)
        _engine.Bind("Status", "Status", cboStatus, True)
        _engine.BeforeSave = AddressOf Rules.UserCheck
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
