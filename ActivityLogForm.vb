Imports System.Drawing
Imports System.Windows.Forms
Public Class ActivityLogForm
    Private _engine As CrudEngine

    Public Sub New()
        InitializeComponent()
        Theme.MakeEmbedded(Me)
    End Sub

    Private Sub ActivityLogForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _engine = New CrudEngine("Activity Log", "ActivityLog", "SELECT Id, Stamp AS [Date & Time], UserName AS [User], Action, Detail FROM ActivityLog ORDER BY Id DESC LIMIT 1000", dgv, txtSearch, Nothing, lblCount)
        _engine.Start()
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        _engine.ExportCsv()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        _engine.Refresh()
    End Sub
End Class
