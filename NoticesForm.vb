Imports System.Drawing
Imports System.Windows.Forms
Public Class NoticesForm
    Private _engine As CrudEngine

    Public Sub New()
        InitializeComponent()
        Theme.MakeEmbedded(Me)
    End Sub

    Private Sub NoticesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _engine = New CrudEngine("Notice Board", "Notices", "SELECT Id, Title, Message, DatePosted AS [Posted], PostedBy AS [By], Audience FROM Notices ORDER BY Id DESC", dgv, txtSearch, lblMode, lblCount)
        _engine.Bind("Title", "Title", txtTitle, True)
        _engine.Bind("Message", "Message", txtMessage, True)
        _engine.Bind("DatePosted", "Date Posted", dtpDatePosted)
        _engine.Bind("PostedBy", "Posted By", txtPostedBy, False, "{user}")
        _engine.Bind("Audience", "Audience", cboAudience, True)
        _engine.Bind("ExpiryDate", "Expiry Date", dtpExpiryDate)
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
