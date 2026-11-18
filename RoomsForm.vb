Imports System.Drawing
Imports System.Windows.Forms
Public Class RoomsForm
    Private _engine As CrudEngine

    Public Sub New()
        InitializeComponent()
        Theme.MakeEmbedded(Me)
    End Sub

    Private Sub RoomsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _engine = New CrudEngine("Rooms & Beds", "Rooms", "SELECT r.Id, h.Name AS Hostel, r.RoomNo AS Room, r.Floor, r.RoomType AS [Room Type], r.Capacity, (SELECT COUNT(*) FROM Allocations a WHERE a.RoomId = r.Id AND a.Status = 'Active') AS Occupied, r.FeePerSemester AS [Fee (UGX)], r.Status FROM Rooms r JOIN Hostels h ON h.Id = r.HostelId ORDER BY h.Name, r.RoomNo", dgv, txtSearch, lblMode, lblCount)
        _engine.Bind("HostelId", "Hostel", cboHostelId, True, "", Rules.HostelLk)
        _engine.Bind("RoomNo", "Room Number", txtRoomNo, True)
        _engine.Bind("Floor", "Floor (0 = ground)", numFloor)
        _engine.Bind("RoomType", "Room Type", cboRoomType, True)
        _engine.Bind("Capacity", "Capacity (beds)", numCapacity, True, "2")
        _engine.Bind("FeePerSemester", "Fee per Semester (UGX)", numFeePerSemester)
        _engine.Bind("Status", "Status", cboStatus, True)
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
