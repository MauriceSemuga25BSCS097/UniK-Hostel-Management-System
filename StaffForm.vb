Imports System.Drawing
Imports System.Windows.Forms
Public Class StaffForm
    Private _engine As CrudEngine

    Public Sub New()
        InitializeComponent()
        Theme.MakeEmbedded(Me)
    End Sub

    Private Sub StaffForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _engine = New CrudEngine("Hostel Staff", "Staff", "SELECT t.Id, t.FullName AS [Full Name], t.Position, t.Phone, IFNULL(h.Name,'-') AS Hostel, t.Shift, t.Status FROM Staff t LEFT JOIN Hostels h ON h.Id = t.HostelId ORDER BY t.FullName", dgv, txtSearch, lblMode, lblCount)
        _engine.Bind("FullName", "Full Name", txtFullName, True)
        _engine.Bind("Position", "Position", cboPosition, True)
        _engine.Bind("Phone", "Phone", txtPhone)
        _engine.Bind("HostelId", "Assigned Hostel", cboHostelId, False, "", Rules.HostelNoneLk)
        _engine.Bind("Shift", "Shift", cboShift, True)
        _engine.Bind("DateEmployed", "Date Employed", dtpDateEmployed)
        _engine.Bind("Status", "Status", cboStatus, True)
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
