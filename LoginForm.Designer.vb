<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.pnlRight = New System.Windows.Forms.Panel()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.lblSub = New System.Windows.Forms.Label()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.lblPass = New System.Windows.Forms.Label()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.chkShow = New System.Windows.Forms.CheckBox()
        Me.lblError = New System.Windows.Forms.Label()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.lblFooter = New System.Windows.Forms.Label()
        Me.pnlTopStrip = New System.Windows.Forms.Panel()
        Me.pnlLeft = New System.Windows.Forms.Panel()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.lblUniv = New System.Windows.Forms.Label()
        Me.lblSystem = New System.Windows.Forms.Label()
        Me.pnlBand = New System.Windows.Forms.Panel()
        Me.pnlEdge = New System.Windows.Forms.Panel()
        Me.pnlRight.SuspendLayout()
        Me.pnlTopStrip.SuspendLayout()
        Me.pnlLeft.SuspendLayout()
        Me.pnlBand.SuspendLayout()
        Me.pnlEdge.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlRight
        '
        Me.pnlRight.BackColor = System.Drawing.Color.White
        Me.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlRight.Size = New System.Drawing.Size(520, 540)
        Me.pnlRight.Name = "pnlRight"
        Me.pnlRight.TabIndex = 0
        Me.pnlRight.Controls.Add(Me.lblWelcome)
        Me.pnlRight.Controls.Add(Me.lblSub)
        Me.pnlRight.Controls.Add(Me.lblUser)
        Me.pnlRight.Controls.Add(Me.txtUser)
        Me.pnlRight.Controls.Add(Me.lblPass)
        Me.pnlRight.Controls.Add(Me.txtPass)
        Me.pnlRight.Controls.Add(Me.chkShow)
        Me.pnlRight.Controls.Add(Me.lblError)
        Me.pnlRight.Controls.Add(Me.btnLogin)
        Me.pnlRight.Controls.Add(Me.lblFooter)
        Me.pnlRight.Controls.Add(Me.pnlTopStrip)
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Location = New System.Drawing.Point(90, 80)
        Me.lblWelcome.Text = "Welcome Back"
        Me.lblWelcome.Font = New System.Drawing.Font("Segoe UI", 24!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.TabIndex = 0
        '
        'lblSub
        '
        Me.lblSub.AutoSize = True
        Me.lblSub.Location = New System.Drawing.Point(92, 130)
        Me.lblSub.Text = "Sign in to the Hostel Management System"
        Me.lblSub.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSub.ForeColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.lblSub.Name = "lblSub"
        Me.lblSub.TabIndex = 1
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Location = New System.Drawing.Point(92, 185)
        Me.lblUser.Text = "Username"
        Me.lblUser.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.lblUser.Name = "lblUser"
        Me.lblUser.TabIndex = 2
        '
        'txtUser
        '
        Me.txtUser.Font = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUser.Location = New System.Drawing.Point(90, 210)
        Me.txtUser.Size = New System.Drawing.Size(340, 29)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.TabIndex = 3
        '
        'lblPass
        '
        Me.lblPass.AutoSize = True
        Me.lblPass.Location = New System.Drawing.Point(92, 262)
        Me.lblPass.Text = "Password"
        Me.lblPass.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPass.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.lblPass.Name = "lblPass"
        Me.lblPass.TabIndex = 4
        '
        'txtPass
        '
        Me.txtPass.Font = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPass.Location = New System.Drawing.Point(90, 287)
        Me.txtPass.Size = New System.Drawing.Size(340, 29)
        Me.txtPass.UseSystemPasswordChar = True
        Me.txtPass.Name = "txtPass"
        Me.txtPass.TabIndex = 5
        '
        'chkShow
        '
        Me.chkShow.AutoSize = True
        Me.chkShow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.chkShow.Location = New System.Drawing.Point(92, 330)
        Me.chkShow.Text = "Show password"
        Me.chkShow.UseVisualStyleBackColor = True
        Me.chkShow.Name = "chkShow"
        Me.chkShow.TabIndex = 6
        '
        'lblError
        '
        Me.lblError.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblError.ForeColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.lblError.Location = New System.Drawing.Point(92, 362)
        Me.lblError.Size = New System.Drawing.Size(340, 24)
        Me.lblError.Text = ""
        Me.lblError.Name = "lblError"
        Me.lblError.TabIndex = 7
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogin.FlatAppearance.BorderSize = 0
        Me.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Location = New System.Drawing.Point(90, 395)
        Me.btnLogin.Size = New System.Drawing.Size(340, 46)
        Me.btnLogin.Text = "SIGN IN"
        Me.btnLogin.UseVisualStyleBackColor = False
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.TabIndex = 8
        '
        'lblFooter
        '
        Me.lblFooter.AutoSize = True
        Me.lblFooter.Location = New System.Drawing.Point(92, 490)
        Me.lblFooter.Text = "University of Kisubi  |  In Virtue We Educate"
        Me.lblFooter.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFooter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.lblFooter.Name = "lblFooter"
        Me.lblFooter.TabIndex = 9
        '
        'pnlTopStrip
        '
        Me.pnlTopStrip.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.pnlTopStrip.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTopStrip.Size = New System.Drawing.Size(520, 8)
        Me.pnlTopStrip.Name = "pnlTopStrip"
        Me.pnlTopStrip.TabIndex = 10
        '
        'pnlLeft
        '
        Me.pnlLeft.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlLeft.Size = New System.Drawing.Size(380, 540)
        Me.pnlLeft.Name = "pnlLeft"
        Me.pnlLeft.TabIndex = 1
        Me.pnlLeft.Controls.Add(Me.picLogo)
        Me.pnlLeft.Controls.Add(Me.lblUniv)
        Me.pnlLeft.Controls.Add(Me.lblSystem)
        Me.pnlLeft.Controls.Add(Me.pnlBand)
        Me.pnlLeft.Controls.Add(Me.pnlEdge)
        '
        'picLogo
        '
        Me.picLogo.Location = New System.Drawing.Point(85, 50)
        Me.picLogo.Size = New System.Drawing.Size(210, 288)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picLogo.TabStop = False
        Me.picLogo.Name = "picLogo"
        Me.picLogo.TabIndex = 0
        '
        'lblUniv
        '
        Me.lblUniv.Font = New System.Drawing.Font("Segoe UI", 16!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUniv.ForeColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.lblUniv.Location = New System.Drawing.Point(0, 360)
        Me.lblUniv.Size = New System.Drawing.Size(380, 36)
        Me.lblUniv.Text = "UNIVERSITY OF KISUBI"
        Me.lblUniv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblUniv.Name = "lblUniv"
        Me.lblUniv.TabIndex = 1
        '
        'lblSystem
        '
        Me.lblSystem.Font = New System.Drawing.Font("Segoe UI", 11!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSystem.ForeColor = System.Drawing.Color.White
        Me.lblSystem.Location = New System.Drawing.Point(0, 398)
        Me.lblSystem.Size = New System.Drawing.Size(380, 28)
        Me.lblSystem.Text = "HOSTEL MANAGEMENT SYSTEM"
        Me.lblSystem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblSystem.Name = "lblSystem"
        Me.lblSystem.TabIndex = 2
        '
        'pnlBand
        '
        Me.pnlBand.BackColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.pnlBand.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBand.Size = New System.Drawing.Size(380, 14)
        Me.pnlBand.Name = "pnlBand"
        Me.pnlBand.TabIndex = 3
        '
        'pnlEdge
        '
        Me.pnlEdge.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.pnlEdge.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlEdge.Size = New System.Drawing.Size(6, 526)
        Me.pnlEdge.Name = "pnlEdge"
        Me.pnlEdge.TabIndex = 4
        '
        'LoginForm
        '
        Me.AcceptButton = Me.btnLogin
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(900, 540)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "University of Kisubi - Hostel Management System"
        Me.Controls.Add(Me.pnlRight)
        Me.Controls.Add(Me.pnlLeft)
        Me.Name = "LoginForm"
        Me.pnlEdge.ResumeLayout(False)
        Me.pnlEdge.PerformLayout()
        Me.pnlBand.ResumeLayout(False)
        Me.pnlBand.PerformLayout()
        Me.pnlLeft.ResumeLayout(False)
        Me.pnlLeft.PerformLayout()
        Me.pnlTopStrip.ResumeLayout(False)
        Me.pnlTopStrip.PerformLayout()
        Me.pnlRight.ResumeLayout(False)
        Me.pnlRight.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlRight As System.Windows.Forms.Panel
    Friend WithEvents lblWelcome As System.Windows.Forms.Label
    Friend WithEvents lblSub As System.Windows.Forms.Label
    Friend WithEvents lblUser As System.Windows.Forms.Label
    Friend WithEvents txtUser As System.Windows.Forms.TextBox
    Friend WithEvents lblPass As System.Windows.Forms.Label
    Friend WithEvents txtPass As System.Windows.Forms.TextBox
    Friend WithEvents chkShow As System.Windows.Forms.CheckBox
    Friend WithEvents lblError As System.Windows.Forms.Label
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents lblFooter As System.Windows.Forms.Label
    Friend WithEvents pnlTopStrip As System.Windows.Forms.Panel
    Friend WithEvents pnlLeft As System.Windows.Forms.Panel
    Friend WithEvents picLogo As System.Windows.Forms.PictureBox
    Friend WithEvents lblUniv As System.Windows.Forms.Label
    Friend WithEvents lblSystem As System.Windows.Forms.Label
    Friend WithEvents pnlBand As System.Windows.Forms.Panel
    Friend WithEvents pnlEdge As System.Windows.Forms.Panel
End Class
