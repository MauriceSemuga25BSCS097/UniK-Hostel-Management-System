Imports System.Drawing
Imports System.Windows.Forms
Imports System.Data

Public Class LoginForm

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        picLogo.Image = Theme.LoadLogo()
    End Sub

    Private Sub chkShow_CheckedChanged(sender As Object, e As EventArgs) Handles chkShow.CheckedChanged
        txtPass.UseSystemPasswordChar = Not chkShow.Checked
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUser.Text.Trim() = "" OrElse txtPass.Text = "" Then
            lblError.Text = "Enter your username and password."
            Return
        End If
        Dim dt As DataTable = Db.Query("SELECT Username, FullName, Role FROM Users WHERE Username = @p0 COLLATE NOCASE AND PasswordHash = @p1 AND Status = 'Active'",
                                       txtUser.Text.Trim(), Db.Hash(txtPass.Text))
        If dt.Rows.Count = 1 Then
            Db.CurrentUser = CStr(dt.Rows(0)("Username"))
            Db.CurrentName = CStr(dt.Rows(0)("FullName"))
            Db.CurrentRole = CStr(dt.Rows(0)("Role"))
            Db.LogAction("Login", "")
            DialogResult = DialogResult.OK
        Else
            lblError.Text = "Invalid username or password."
            txtPass.Clear()
            txtPass.Focus()
        End If
    End Sub
End Class
