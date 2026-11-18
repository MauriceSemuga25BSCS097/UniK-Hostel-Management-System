<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportsForm
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
        Me.dgvReport = New System.Windows.Forms.DataGridView()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.pnlToolbar = New System.Windows.Forms.Panel()
        Me.lblSelect = New System.Windows.Forms.Label()
        Me.cboReports = New System.Windows.Forms.ComboBox()
        Me.btnRun = New System.Windows.Forms.Button()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.pnlTitle = New System.Windows.Forms.Panel()
        Me.lblPageTitle = New System.Windows.Forms.Label()
        Me.pnlTitleStrip = New System.Windows.Forms.Panel()
        Me.pnlTitleAccent = New System.Windows.Forms.Panel()
        CType(Me.dgvReport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlToolbar.SuspendLayout()
        Me.pnlTitle.SuspendLayout()
        Me.pnlTitleStrip.SuspendLayout()
        Me.pnlTitleAccent.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvReport
        '
        Me.dgvReport.AllowUserToAddRows = False
        Me.dgvReport.AllowUserToDeleteRows = False
        Me.dgvReport.BackgroundColor = System.Drawing.Color.White
        Me.dgvReport.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvReport.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvReport.ReadOnly = True
        Me.dgvReport.RowHeadersVisible = False
        Me.dgvReport.Size = New System.Drawing.Size(1100, 560)
        Me.dgvReport.Name = "dgvReport"
        Me.dgvReport.TabIndex = 0
        '
        'lblStatus
        '
        Me.lblStatus.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblStatus.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.lblStatus.Size = New System.Drawing.Size(1100, 30)
        Me.lblStatus.Text = "  Choose a report above."
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.TabIndex = 1
        '
        'pnlToolbar
        '
        Me.pnlToolbar.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlToolbar.Size = New System.Drawing.Size(1100, 58)
        Me.pnlToolbar.Name = "pnlToolbar"
        Me.pnlToolbar.TabIndex = 2
        Me.pnlToolbar.Controls.Add(Me.lblSelect)
        Me.pnlToolbar.Controls.Add(Me.cboReports)
        Me.pnlToolbar.Controls.Add(Me.btnRun)
        Me.pnlToolbar.Controls.Add(Me.btnExport)
        '
        'lblSelect
        '
        Me.lblSelect.AutoSize = True
        Me.lblSelect.Location = New System.Drawing.Point(12, 17)
        Me.lblSelect.Text = "Select report:"
        Me.lblSelect.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelect.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.lblSelect.Name = "lblSelect"
        Me.lblSelect.TabIndex = 0
        '
        'cboReports
        '
        Me.cboReports.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboReports.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboReports.FormattingEnabled = True
        Me.cboReports.Location = New System.Drawing.Point(130, 13)
        Me.cboReports.Size = New System.Drawing.Size(430, 29)
        Me.cboReports.Name = "cboReports"
        Me.cboReports.TabIndex = 1
        '
        'btnRun
        '
        Me.btnRun.BackColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnRun.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRun.FlatAppearance.BorderSize = 0
        Me.btnRun.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRun.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRun.ForeColor = System.Drawing.Color.White
        Me.btnRun.Location = New System.Drawing.Point(576, 8)
        Me.btnRun.Size = New System.Drawing.Size(120, 40)
        Me.btnRun.Text = "Run Report"
        Me.btnRun.UseVisualStyleBackColor = False
        Me.btnRun.Name = "btnRun"
        Me.btnRun.TabIndex = 2
        '
        'btnExport
        '
        Me.btnExport.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.btnExport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExport.FlatAppearance.BorderSize = 0
        Me.btnExport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExport.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExport.ForeColor = System.Drawing.Color.White
        Me.btnExport.Location = New System.Drawing.Point(704, 8)
        Me.btnExport.Size = New System.Drawing.Size(120, 40)
        Me.btnExport.Text = "Export CSV"
        Me.btnExport.UseVisualStyleBackColor = False
        Me.btnExport.Name = "btnExport"
        Me.btnExport.TabIndex = 3
        '
        'pnlTitle
        '
        Me.pnlTitle.BackColor = System.Drawing.Color.White
        Me.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTitle.Size = New System.Drawing.Size(1000, 64)
        Me.pnlTitle.Name = "pnlTitle"
        Me.pnlTitle.TabIndex = 3
        Me.pnlTitle.Controls.Add(Me.lblPageTitle)
        Me.pnlTitle.Controls.Add(Me.pnlTitleStrip)
        Me.pnlTitle.Controls.Add(Me.pnlTitleAccent)
        '
        'lblPageTitle
        '
        Me.lblPageTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblPageTitle.Font = New System.Drawing.Font("Segoe UI", 18!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPageTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.lblPageTitle.Padding = New System.Windows.Forms.Padding(18, 0, 0, 0)
        Me.lblPageTitle.Text = "Reports"
        Me.lblPageTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblPageTitle.Name = "lblPageTitle"
        Me.lblPageTitle.TabIndex = 0
        '
        'pnlTitleStrip
        '
        Me.pnlTitleStrip.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.pnlTitleStrip.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlTitleStrip.Size = New System.Drawing.Size(1000, 4)
        Me.pnlTitleStrip.Name = "pnlTitleStrip"
        Me.pnlTitleStrip.TabIndex = 1
        '
        'pnlTitleAccent
        '
        Me.pnlTitleAccent.BackColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.pnlTitleAccent.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlTitleAccent.Size = New System.Drawing.Size(8, 60)
        Me.pnlTitleAccent.Name = "pnlTitleAccent"
        Me.pnlTitleAccent.TabIndex = 2
        '
        'ReportsForm
        '
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1100, 700)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text = "Reports"
        Me.Controls.Add(Me.dgvReport)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.pnlToolbar)
        Me.Controls.Add(Me.pnlTitle)
        Me.Name = "ReportsForm"
        Me.pnlTitleAccent.ResumeLayout(False)
        Me.pnlTitleAccent.PerformLayout()
        Me.pnlTitleStrip.ResumeLayout(False)
        Me.pnlTitleStrip.PerformLayout()
        Me.pnlTitle.ResumeLayout(False)
        Me.pnlTitle.PerformLayout()
        Me.pnlToolbar.ResumeLayout(False)
        Me.pnlToolbar.PerformLayout()
        CType(Me.dgvReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvReport As System.Windows.Forms.DataGridView
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents pnlToolbar As System.Windows.Forms.Panel
    Friend WithEvents lblSelect As System.Windows.Forms.Label
    Friend WithEvents cboReports As System.Windows.Forms.ComboBox
    Friend WithEvents btnRun As System.Windows.Forms.Button
    Friend WithEvents btnExport As System.Windows.Forms.Button
    Friend WithEvents pnlTitle As System.Windows.Forms.Panel
    Friend WithEvents lblPageTitle As System.Windows.Forms.Label
    Friend WithEvents pnlTitleStrip As System.Windows.Forms.Panel
    Friend WithEvents pnlTitleAccent As System.Windows.Forms.Panel
End Class
