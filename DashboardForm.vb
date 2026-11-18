Imports System.Drawing
Imports System.Windows.Forms
Imports System.Data

Public Class DashboardForm
    Private _occ As DataTable

    Public Sub New()
        InitializeComponent()
        Theme.MakeEmbedded(Me)
    End Sub

    Private Sub DashboardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblPageTitle.Text = "Dashboard  -  Welcome, " & Db.CurrentName

        _occ = Db.Query("SELECT h.Name AS Name, IFNULL((SELECT SUM(r.Capacity) FROM Rooms r WHERE r.HostelId = h.Id),0) AS Beds, " &
                        "(SELECT COUNT(*) FROM Allocations a JOIN Rooms r2 ON r2.Id = a.RoomId WHERE r2.HostelId = h.Id AND a.Status='Active') AS Occ " &
                        "FROM Hostels h ORDER BY h.Name")

        Dim notes As DataTable = Db.Query("SELECT Title, DatePosted FROM Notices ORDER BY Id DESC LIMIT 10")
        lstNotices.Items.Clear()
        If notes.Rows.Count = 0 Then
            lstNotices.Items.Add("No notices posted yet.")
        Else
            For Each r As DataRow In notes.Rows
                lstNotices.Items.Add(CStr(r("DatePosted")) & "  -  " & CStr(r("Title")))
            Next
        End If

        Dim beds As Double = Db.Num("SELECT IFNULL(SUM(Capacity),0) FROM Rooms")
        Dim occupied As Double = Db.Num("SELECT COUNT(*) FROM Allocations WHERE Status='Active'")
        SetCard(lblStudentsValue, Db.Num("SELECT COUNT(*) FROM Students WHERE Status='Active'").ToString("N0"))
        SetCard(lblHostelsValue, Db.Num("SELECT COUNT(*) FROM Hostels").ToString("N0"))
        SetCard(lblBedsValue, beds.ToString("N0"))
        SetCard(lblOccupiedValue, occupied.ToString("N0"))
        SetCard(lblFreeValue, (beds - occupied).ToString("N0"))
        SetCard(lblFeesValue, "UGX " & Db.Num("SELECT SUM(Amount) FROM Payments WHERE substr(PayDate,1,7) = strftime('%Y-%m','now','localtime')").ToString("N0"))
        SetCard(lblFinesValue, "UGX " & Db.Num("SELECT SUM(Amount) FROM Fines WHERE Status='Unpaid'").ToString("N0"))
        SetCard(lblApplicationsValue, Db.Num("SELECT COUNT(*) FROM Applications WHERE Status='Pending'").ToString("N0"))
        SetCard(lblRepairsValue, Db.Num("SELECT COUNT(*) FROM Maintenance WHERE Status<>'Resolved'").ToString("N0"))
        SetCard(lblVisitorsValue, Db.Num("SELECT COUNT(*) FROM Visitors WHERE (TimeOut='' OR TimeOut IS NULL) AND VisitDate = date('now','localtime')").ToString("N0"))
        SetCard(lblExeatValue, Db.Num("SELECT COUNT(*) FROM Exeat WHERE Status='Pending'").ToString("N0"))
        SetCard(lblComplaintsValue, Db.Num("SELECT COUNT(*) FROM Complaints WHERE Status IN ('Open','Under Review')").ToString("N0"))
        pnlOccupancy.Invalidate()
    End Sub

    Private Sub SetCard(lbl As Label, text As String)
        lbl.Text = text
        lbl.Font = New Font(lbl.Font.FontFamily, If(text.Length > 9, 14.0F, 20.0F), FontStyle.Bold)
    End Sub

    Private Sub pnlOccupancy_Resize(sender As Object, e As EventArgs) Handles pnlOccupancy.Resize
        pnlOccupancy.Invalidate()
    End Sub

    Private Sub pnlOccupancy_Paint(sender As Object, e As PaintEventArgs) Handles pnlOccupancy.Paint
        Dim g As Graphics = e.Graphics
        g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        Using hb As New SolidBrush(Theme.Maroon)
            g.DrawString("Occupancy by Hostel", Theme.FontH2, hb, 16, 10)
        End Using
        If _occ Is Nothing OrElse _occ.Rows.Count = 0 Then
            Using tb As New SolidBrush(Theme.Muted)
                g.DrawString("No hostels registered yet. Add hostels and rooms to see occupancy.", Theme.FontBase, tb, 16, 50)
            End Using
            Return
        End If
        Dim y As Integer = 52
        Dim barX As Integer = 190
        Dim barW As Integer = Math.Max(100, pnlOccupancy.Width - barX - 190)
        For Each r As DataRow In _occ.Rows
            If y + 30 > pnlOccupancy.Height Then Exit For
            Dim beds As Double = Convert.ToDouble(r("Beds"))
            Dim occ As Double = Convert.ToDouble(r("Occ"))
            Dim pct As Double = If(beds > 0, occ / beds, 0)
            Using nb As New SolidBrush(Theme.Navy)
                g.DrawString(CStr(r("Name")), Theme.FontBold, nb, 16, y)
            End Using
            Using back As New SolidBrush(Color.FromArgb(235, 230, 215))
                g.FillRectangle(back, barX, y, barW, 24)
            End Using
            Dim fillColor As Color = If(pct >= 0.9, Theme.Maroon, If(pct >= 0.6, Theme.Mustard, Theme.Navy))
            Using fb As New SolidBrush(fillColor)
                g.FillRectangle(fb, barX, y, CInt(barW * pct), 24)
            End Using
            Using tb As New SolidBrush(Theme.Navy)
                g.DrawString(String.Format("{0:0}/{1:0} beds  ({2:P0})", occ, beds, pct), Theme.FontBase, tb, barX + barW + 10, y)
            End Using
            y += 36
        Next
    End Sub
End Class
