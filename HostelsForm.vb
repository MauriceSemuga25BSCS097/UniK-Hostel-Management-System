Imports System.Drawing
Imports System.Windows.Forms
Public Class HostelsForm
    Private _engine As CrudEngine

    Public Sub New()
        InitializeComponent()
        Theme.MakeEmbedded(Me)
    End Sub

    Private Sub HostelsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _engine = New CrudEngine("Hostels / Halls of Residence", "Hostels", "SELECT h.Id, h.Name, h.Type, h.Location, h.WardenName AS Warden, h.Contact, IFNULL((SELECT SUM(Capacity) FROM Rooms WHERE HostelId = h.Id),0) AS Beds, (SELECT COUNT(*) FROM Allocations a JOIN Rooms r ON r.Id = a.RoomId WHERE r.HostelId = h.Id AND a.Status = 'Active') AS Occupied FROM Hostels h ORDER BY h.Name", dgv, txtSearch, lblMode, lblCount)
        _engine.Bind("Name", "Hostel Name", txtName, True)
        _engine.Bind("Type", "Type", cboType, True)
        _engine.Bind("Location", "Location", txtLocation)
        _engine.Bind("WardenName", "Warden In Charge", txtWardenName)
        _engine.Bind("Contact", "Contact Phone", txtContact)
        _engine.Bind("Description", "Description / Rules", txtDescription)
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
