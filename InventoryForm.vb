Imports System.Drawing
Imports System.Windows.Forms
Public Class InventoryForm
    Private _engine As CrudEngine

    Public Sub New()
        InitializeComponent()
        Theme.MakeEmbedded(Me)
    End Sub

    Private Sub InventoryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _engine = New CrudEngine("Hostel Inventory & Assets", "Inventory", "SELECT i.Id, i.ItemName AS Item, i.Category, h.Name AS Hostel, IFNULL(r.RoomNo,'-') AS Room, i.Quantity, i.ItemCondition AS Condition, i.DateAdded AS [Added] FROM Inventory i JOIN Hostels h ON h.Id = i.HostelId LEFT JOIN Rooms r ON r.Id = i.RoomId ORDER BY i.Id DESC", dgv, txtSearch, lblMode, lblCount)
        _engine.Bind("ItemName", "Item Name", txtItemName, True)
        _engine.Bind("Category", "Category", cboCategory, True)
        _engine.Bind("HostelId", "Hostel", cboHostelId, True, "", Rules.HostelLk)
        _engine.Bind("RoomId", "Room (if assigned)", cboRoomId, False, "", Rules.RoomNoneLk)
        _engine.Bind("Quantity", "Quantity", numQuantity, False, "1")
        _engine.Bind("ItemCondition", "Condition", cboItemCondition, True)
        _engine.Bind("DateAdded", "Date Added", dtpDateAdded)
        _engine.Bind("Notes", "Notes", txtNotes)
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
