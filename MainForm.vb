Imports System.Drawing
Imports System.Windows.Forms
Imports System.Linq

Public Class MainForm
    Public LoggedOut As Boolean = False
    Private ReadOnly _navButtons As New List(Of Button)

    Private Function Allowed(key As String) As Boolean
        Select Case Db.CurrentRole
            Case "Admin"
                Return True
            Case "Warden"
                Return key <> "users" AndAlso key <> "log"
            Case "Bursar"
                Return New String() {"dashboard", "students", "payments", "fines", "reports"}.Contains(key)
            Case "Security"
                Return New String() {"dashboard", "visitors", "exeat", "students"}.Contains(key)
        End Select
        Return key = "dashboard"
    End Function

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        picLogo.Image = Theme.LoadLogo()
        lblUserName.Text = Db.CurrentName
        lblUserRole.Text = Db.CurrentRole & "  |  " & Date.Today.ToString("dddd, dd MMM yyyy")
        ApplyRoles()
        ShowModule("dashboard")
    End Sub

    ''' <summary>Hides menu buttons (and empty group headings) the signed-in role may not use.</summary>
    Private Sub ApplyRoles()
        Dim head As Label = Nothing
        Dim anyVisible As Boolean = False
        For Each c As Control In pnlSide.Controls
            If TypeOf c Is Label Then
                If head IsNot Nothing Then head.Visible = anyVisible
                head = DirectCast(c, Label)
                anyVisible = False
            ElseIf TypeOf c Is Button Then
                Dim b As Button = DirectCast(c, Button)
                b.Visible = Allowed(CStr(b.Tag))
                If b.Visible Then anyVisible = True
                _navButtons.Add(b)
                AddHandler b.Click, AddressOf NavButton_Click
            End If
        Next
        If head IsNot Nothing Then head.Visible = anyVisible
    End Sub

    Private Sub NavButton_Click(sender As Object, e As EventArgs)
        ShowModule(CStr(DirectCast(sender, Button).Tag))
    End Sub

    Private Sub ShowModule(key As String)
        If Not Allowed(key) Then Return
        For Each c As Control In pnlContent.Controls.Cast(Of Control).ToList()
            pnlContent.Controls.Remove(c)
            c.Dispose()
        Next
        Dim f As Form = ModuleFactory.Build(key)
        f.TopLevel = False
        f.Dock = DockStyle.Fill
        pnlContent.Controls.Add(f)
        f.Show()
        For Each b As Button In _navButtons
            If CStr(b.Tag) = key Then
                b.BackColor = Theme.Mustard
                b.ForeColor = Theme.Navy
                b.Font = Theme.FontBold
            Else
                b.BackColor = Theme.Navy
                b.ForeColor = Color.White
                b.Font = Theme.FontBase
            End If
        Next
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        If MessageBox.Show("Log out of the system?", "Log out", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Db.LogAction("Logout", "")
            LoggedOut = True
            Close()
        End If
    End Sub
End Class
