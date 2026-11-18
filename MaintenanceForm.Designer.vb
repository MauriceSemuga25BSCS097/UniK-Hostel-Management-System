<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MaintenanceForm
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
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.pnlSearch = New System.Windows.Forms.Panel()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.pnlLeft = New System.Windows.Forms.Panel()
        Me.pnlFields = New System.Windows.Forms.Panel()
        Me.lblHostelId = New System.Windows.Forms.Label()
        Me.cboHostelId = New System.Windows.Forms.ComboBox()
        Me.lblRoomId = New System.Windows.Forms.Label()
        Me.cboRoomId = New System.Windows.Forms.ComboBox()
        Me.lblCategory = New System.Windows.Forms.Label()
        Me.cboCategory = New System.Windows.Forms.ComboBox()
        Me.lblIssue = New System.Windows.Forms.Label()
        Me.txtIssue = New System.Windows.Forms.TextBox()
        Me.lblPriority = New System.Windows.Forms.Label()
        Me.cboPriority = New System.Windows.Forms.ComboBox()
        Me.lblReportedBy = New System.Windows.Forms.Label()
        Me.txtReportedBy = New System.Windows.Forms.TextBox()
        Me.lblDateReported = New System.Windows.Forms.Label()
        Me.dtpDateReported = New System.Windows.Forms.DateTimePicker()
        Me.lblAssignedTo = New System.Windows.Forms.Label()
        Me.txtAssignedTo = New System.Windows.Forms.TextBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.cboStatus = New System.Windows.Forms.ComboBox()
        Me.lblDateResolved = New System.Windows.Forms.Label()
        Me.dtpDateResolved = New System.Windows.Forms.DateTimePicker()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.numCost = New System.Windows.Forms.NumericUpDown()
        Me.pnlButtons = New System.Windows.Forms.Panel()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.lblMode = New System.Windows.Forms.Label()
        Me.pnlTitle = New System.Windows.Forms.Panel()
        Me.lblPageTitle = New System.Windows.Forms.Label()
        Me.pnlTitleStrip = New System.Windows.Forms.Panel()
        Me.pnlTitleAccent = New System.Windows.Forms.Panel()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlRight.SuspendLayout()
        Me.pnlSearch.SuspendLayout()
        Me.pnlLeft.SuspendLayout()
        Me.pnlFields.SuspendLayout()
        Me.pnlButtons.SuspendLayout()
        Me.pnlTitle.SuspendLayout()
        Me.pnlTitleStrip.SuspendLayout()
        Me.pnlTitleAccent.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlRight
        '
        Me.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlRight.Padding = New System.Windows.Forms.Padding(12, 12, 12, 12)
        Me.pnlRight.Size = New System.Drawing.Size(670, 636)
        Me.pnlRight.Name = "pnlRight"
        Me.pnlRight.TabIndex = 0
        Me.pnlRight.Controls.Add(Me.dgv)
        Me.pnlRight.Controls.Add(Me.lblCount)
        Me.pnlRight.Controls.Add(Me.pnlSearch)
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.BackgroundColor = System.Drawing.Color.White
        Me.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv.ReadOnly = True
        Me.dgv.RowHeadersVisible = False
        Me.dgv.Size = New System.Drawing.Size(646, 500)
        Me.dgv.Name = "dgv"
        Me.dgv.TabIndex = 0
        '
        'lblCount
        '
        Me.lblCount.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblCount.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.lblCount.Size = New System.Drawing.Size(646, 28)
        Me.lblCount.Text = ""
        Me.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblCount.Name = "lblCount"
        Me.lblCount.TabIndex = 1
        '
        'pnlSearch
        '
        Me.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlSearch.Size = New System.Drawing.Size(646, 50)
        Me.pnlSearch.Name = "pnlSearch"
        Me.pnlSearch.TabIndex = 2
        Me.pnlSearch.Controls.Add(Me.lblSearch)
        Me.pnlSearch.Controls.Add(Me.txtSearch)
        Me.pnlSearch.Controls.Add(Me.btnExport)
        Me.pnlSearch.Controls.Add(Me.btnRefresh)
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Location = New System.Drawing.Point(0, 13)
        Me.lblSearch.Text = "Search:"
        Me.lblSearch.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.TabIndex = 0
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(70, 9)
        Me.txtSearch.Size = New System.Drawing.Size(320, 29)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.TabIndex = 1
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
        Me.btnExport.Location = New System.Drawing.Point(404, 5)
        Me.btnExport.Size = New System.Drawing.Size(120, 40)
        Me.btnExport.Text = "Export CSV"
        Me.btnExport.UseVisualStyleBackColor = False
        Me.btnExport.Name = "btnExport"
        Me.btnExport.TabIndex = 2
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRefresh.FlatAppearance.BorderSize = 0
        Me.btnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.btnRefresh.Location = New System.Drawing.Point(532, 5)
        Me.btnRefresh.Size = New System.Drawing.Size(100, 40)
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = False
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.TabIndex = 3
        '
        'pnlLeft
        '
        Me.pnlLeft.BackColor = System.Drawing.Color.White
        Me.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlLeft.Padding = New System.Windows.Forms.Padding(10, 10, 10, 10)
        Me.pnlLeft.Size = New System.Drawing.Size(430, 636)
        Me.pnlLeft.Name = "pnlLeft"
        Me.pnlLeft.TabIndex = 1
        Me.pnlLeft.Controls.Add(Me.pnlFields)
        Me.pnlLeft.Controls.Add(Me.pnlButtons)
        Me.pnlLeft.Controls.Add(Me.lblMode)
        '
        'pnlFields
        '
        Me.pnlFields.AutoScroll = True
        Me.pnlFields.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlFields.Size = New System.Drawing.Size(410, 500)
        Me.pnlFields.Name = "pnlFields"
        Me.pnlFields.TabIndex = 0
        Me.pnlFields.Controls.Add(Me.lblHostelId)
        Me.pnlFields.Controls.Add(Me.cboHostelId)
        Me.pnlFields.Controls.Add(Me.lblRoomId)
        Me.pnlFields.Controls.Add(Me.cboRoomId)
        Me.pnlFields.Controls.Add(Me.lblCategory)
        Me.pnlFields.Controls.Add(Me.cboCategory)
        Me.pnlFields.Controls.Add(Me.lblIssue)
        Me.pnlFields.Controls.Add(Me.txtIssue)
        Me.pnlFields.Controls.Add(Me.lblPriority)
        Me.pnlFields.Controls.Add(Me.cboPriority)
        Me.pnlFields.Controls.Add(Me.lblReportedBy)
        Me.pnlFields.Controls.Add(Me.txtReportedBy)
        Me.pnlFields.Controls.Add(Me.lblDateReported)
        Me.pnlFields.Controls.Add(Me.dtpDateReported)
        Me.pnlFields.Controls.Add(Me.lblAssignedTo)
        Me.pnlFields.Controls.Add(Me.txtAssignedTo)
        Me.pnlFields.Controls.Add(Me.lblStatus)
        Me.pnlFields.Controls.Add(Me.cboStatus)
        Me.pnlFields.Controls.Add(Me.lblDateResolved)
        Me.pnlFields.Controls.Add(Me.dtpDateResolved)
        Me.pnlFields.Controls.Add(Me.lblCost)
        Me.pnlFields.Controls.Add(Me.numCost)
        '
        'lblHostelId
        '
        Me.lblHostelId.AutoSize = True
        Me.lblHostelId.Location = New System.Drawing.Point(6, 6)
        Me.lblHostelId.Text = "Hostel *"
        Me.lblHostelId.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHostelId.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.lblHostelId.Name = "lblHostelId"
        Me.lblHostelId.TabIndex = 0
        '
        'cboHostelId
        '
        Me.cboHostelId.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboHostelId.Location = New System.Drawing.Point(8, 30)
        Me.cboHostelId.Size = New System.Drawing.Size(365, 29)
        Me.cboHostelId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboHostelId.FormattingEnabled = True
        Me.cboHostelId.Name = "cboHostelId"
        Me.cboHostelId.TabIndex = 1
        '
        'lblRoomId
        '
        Me.lblRoomId.AutoSize = True
        Me.lblRoomId.Location = New System.Drawing.Point(6, 71)
        Me.lblRoomId.Text = "Room (if specific)"
        Me.lblRoomId.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRoomId.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.lblRoomId.Name = "lblRoomId"
        Me.lblRoomId.TabIndex = 2
        '
        'cboRoomId
        '
        Me.cboRoomId.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboRoomId.Location = New System.Drawing.Point(8, 95)
        Me.cboRoomId.Size = New System.Drawing.Size(365, 29)
        Me.cboRoomId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRoomId.FormattingEnabled = True
        Me.cboRoomId.Name = "cboRoomId"
        Me.cboRoomId.TabIndex = 3
        '
        'lblCategory
        '
        Me.lblCategory.AutoSize = True
        Me.lblCategory.Location = New System.Drawing.Point(6, 136)
        Me.lblCategory.Text = "Category *"
        Me.lblCategory.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCategory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.TabIndex = 4
        '
        'cboCategory
        '
        Me.cboCategory.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCategory.Location = New System.Drawing.Point(8, 160)
        Me.cboCategory.Size = New System.Drawing.Size(365, 29)
        Me.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCategory.FormattingEnabled = True
        Me.cboCategory.Items.AddRange(New Object() {"Plumbing", "Electrical", "Furniture", "Carpentry", "Cleaning", "Security / Locks", "Other"})
        Me.cboCategory.Name = "cboCategory"
        Me.cboCategory.TabIndex = 5
        '
        'lblIssue
        '
        Me.lblIssue.AutoSize = True
        Me.lblIssue.Location = New System.Drawing.Point(6, 201)
        Me.lblIssue.Text = "Issue Description *"
        Me.lblIssue.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIssue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.lblIssue.Name = "lblIssue"
        Me.lblIssue.TabIndex = 6
        '
        'txtIssue
        '
        Me.txtIssue.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIssue.Location = New System.Drawing.Point(8, 225)
        Me.txtIssue.Size = New System.Drawing.Size(365, 72)
        Me.txtIssue.Multiline = True
        Me.txtIssue.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtIssue.Name = "txtIssue"
        Me.txtIssue.TabIndex = 7
        '
        'lblPriority
        '
        Me.lblPriority.AutoSize = True
        Me.lblPriority.Location = New System.Drawing.Point(6, 309)
        Me.lblPriority.Text = "Priority *"
        Me.lblPriority.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPriority.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.lblPriority.Name = "lblPriority"
        Me.lblPriority.TabIndex = 8
        '
        'cboPriority
        '
        Me.cboPriority.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPriority.Location = New System.Drawing.Point(8, 333)
        Me.cboPriority.Size = New System.Drawing.Size(365, 29)
        Me.cboPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPriority.FormattingEnabled = True
        Me.cboPriority.Items.AddRange(New Object() {"Low", "Medium", "High", "Urgent"})
        Me.cboPriority.Name = "cboPriority"
        Me.cboPriority.TabIndex = 9
        '
        'lblReportedBy
        '
        Me.lblReportedBy.AutoSize = True
        Me.lblReportedBy.Location = New System.Drawing.Point(6, 374)
        Me.lblReportedBy.Text = "Reported By"
        Me.lblReportedBy.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReportedBy.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.lblReportedBy.Name = "lblReportedBy"
        Me.lblReportedBy.TabIndex = 10
        '
        'txtReportedBy
        '
        Me.txtReportedBy.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReportedBy.Location = New System.Drawing.Point(8, 398)
        Me.txtReportedBy.Size = New System.Drawing.Size(365, 29)
        Me.txtReportedBy.Name = "txtReportedBy"
        Me.txtReportedBy.TabIndex = 11
        '
        'lblDateReported
        '
        Me.lblDateReported.AutoSize = True
        Me.lblDateReported.Location = New System.Drawing.Point(6, 439)
        Me.lblDateReported.Text = "Date Reported"
        Me.lblDateReported.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateReported.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.lblDateReported.Name = "lblDateReported"
        Me.lblDateReported.TabIndex = 12
        '
        'dtpDateReported
        '
        Me.dtpDateReported.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDateReported.Location = New System.Drawing.Point(8, 463)
        Me.dtpDateReported.Size = New System.Drawing.Size(365, 29)
        Me.dtpDateReported.CustomFormat = "dd MMM yyyy"
        Me.dtpDateReported.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateReported.Name = "dtpDateReported"
        Me.dtpDateReported.TabIndex = 13
        '
        'lblAssignedTo
        '
        Me.lblAssignedTo.AutoSize = True
        Me.lblAssignedTo.Location = New System.Drawing.Point(6, 504)
        Me.lblAssignedTo.Text = "Assigned To"
        Me.lblAssignedTo.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAssignedTo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.lblAssignedTo.Name = "lblAssignedTo"
        Me.lblAssignedTo.TabIndex = 14
        '
        'txtAssignedTo
        '
        Me.txtAssignedTo.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAssignedTo.Location = New System.Drawing.Point(8, 528)
        Me.txtAssignedTo.Size = New System.Drawing.Size(365, 29)
        Me.txtAssignedTo.Name = "txtAssignedTo"
        Me.txtAssignedTo.TabIndex = 15
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(6, 569)
        Me.lblStatus.Text = "Status *"
        Me.lblStatus.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.TabIndex = 16
        '
        'cboStatus
        '
        Me.cboStatus.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboStatus.Location = New System.Drawing.Point(8, 593)
        Me.cboStatus.Size = New System.Drawing.Size(365, 29)
        Me.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.Items.AddRange(New Object() {"Open", "In Progress", "Resolved"})
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.TabIndex = 17
        '
        'lblDateResolved
        '
        Me.lblDateResolved.AutoSize = True
        Me.lblDateResolved.Location = New System.Drawing.Point(6, 634)
        Me.lblDateResolved.Text = "Date Resolved"
        Me.lblDateResolved.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateResolved.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.lblDateResolved.Name = "lblDateResolved"
        Me.lblDateResolved.TabIndex = 18
        '
        'dtpDateResolved
        '
        Me.dtpDateResolved.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDateResolved.Location = New System.Drawing.Point(8, 658)
        Me.dtpDateResolved.Size = New System.Drawing.Size(365, 29)
        Me.dtpDateResolved.CustomFormat = "dd MMM yyyy"
        Me.dtpDateResolved.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateResolved.ShowCheckBox = True
        Me.dtpDateResolved.Name = "dtpDateResolved"
        Me.dtpDateResolved.TabIndex = 19
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.Location = New System.Drawing.Point(6, 699)
        Me.lblCost.Text = "Repair Cost (UGX)"
        Me.lblCost.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCost.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.lblCost.Name = "lblCost"
        Me.lblCost.TabIndex = 20
        '
        'numCost
        '
        Me.numCost.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numCost.Location = New System.Drawing.Point(8, 723)
        Me.numCost.Size = New System.Drawing.Size(365, 29)
        Me.numCost.Increment = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.numCost.Maximum = New Decimal(New Integer() {1000000000, 0, 0, 0})
        Me.numCost.ThousandsSeparator = True
        Me.numCost.Name = "numCost"
        Me.numCost.TabIndex = 21
        '
        'pnlButtons
        '
        Me.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlButtons.Size = New System.Drawing.Size(410, 56)
        Me.pnlButtons.Name = "pnlButtons"
        Me.pnlButtons.TabIndex = 1
        Me.pnlButtons.Controls.Add(Me.btnSave)
        Me.pnlButtons.Controls.Add(Me.btnNew)
        Me.pnlButtons.Controls.Add(Me.btnDelete)
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.btnSave.Location = New System.Drawing.Point(6, 8)
        Me.btnSave.Size = New System.Drawing.Size(118, 40)
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        Me.btnSave.Name = "btnSave"
        Me.btnSave.TabIndex = 0
        '
        'btnNew
        '
        Me.btnNew.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.btnNew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNew.FlatAppearance.BorderSize = 0
        Me.btnNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNew.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.ForeColor = System.Drawing.Color.White
        Me.btnNew.Location = New System.Drawing.Point(130, 8)
        Me.btnNew.Size = New System.Drawing.Size(118, 40)
        Me.btnNew.Text = "New / Clear"
        Me.btnNew.UseVisualStyleBackColor = False
        Me.btnNew.Name = "btnNew"
        Me.btnNew.TabIndex = 1
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.FlatAppearance.BorderSize = 0
        Me.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Location = New System.Drawing.Point(254, 8)
        Me.btnDelete.Size = New System.Drawing.Size(118, 40)
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.TabIndex = 2
        '
        'lblMode
        '
        Me.lblMode.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblMode.Font = New System.Drawing.Font("Segoe UI", 13!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.lblMode.Size = New System.Drawing.Size(410, 34)
        Me.lblMode.Text = "NEW RECORD"
        Me.lblMode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblMode.Name = "lblMode"
        Me.lblMode.TabIndex = 2
        '
        'pnlTitle
        '
        Me.pnlTitle.BackColor = System.Drawing.Color.White
        Me.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTitle.Size = New System.Drawing.Size(1000, 64)
        Me.pnlTitle.Name = "pnlTitle"
        Me.pnlTitle.TabIndex = 2
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
        Me.lblPageTitle.Text = "Maintenance & Repairs"
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
        'MaintenanceForm
        '
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1100, 700)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text = "Maintenance & Repairs"
        Me.Controls.Add(Me.pnlRight)
        Me.Controls.Add(Me.pnlLeft)
        Me.Controls.Add(Me.pnlTitle)
        Me.Name = "MaintenanceForm"
        Me.pnlTitleAccent.ResumeLayout(False)
        Me.pnlTitleAccent.PerformLayout()
        Me.pnlTitleStrip.ResumeLayout(False)
        Me.pnlTitleStrip.PerformLayout()
        Me.pnlTitle.ResumeLayout(False)
        Me.pnlTitle.PerformLayout()
        Me.pnlButtons.ResumeLayout(False)
        Me.pnlButtons.PerformLayout()
        Me.pnlFields.ResumeLayout(False)
        Me.pnlFields.PerformLayout()
        Me.pnlLeft.ResumeLayout(False)
        Me.pnlLeft.PerformLayout()
        Me.pnlSearch.ResumeLayout(False)
        Me.pnlSearch.PerformLayout()
        Me.pnlRight.ResumeLayout(False)
        Me.pnlRight.PerformLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlRight As System.Windows.Forms.Panel
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents lblCount As System.Windows.Forms.Label
    Friend WithEvents pnlSearch As System.Windows.Forms.Panel
    Friend WithEvents lblSearch As System.Windows.Forms.Label
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents btnExport As System.Windows.Forms.Button
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents pnlLeft As System.Windows.Forms.Panel
    Friend WithEvents pnlFields As System.Windows.Forms.Panel
    Friend WithEvents lblHostelId As System.Windows.Forms.Label
    Friend WithEvents cboHostelId As System.Windows.Forms.ComboBox
    Friend WithEvents lblRoomId As System.Windows.Forms.Label
    Friend WithEvents cboRoomId As System.Windows.Forms.ComboBox
    Friend WithEvents lblCategory As System.Windows.Forms.Label
    Friend WithEvents cboCategory As System.Windows.Forms.ComboBox
    Friend WithEvents lblIssue As System.Windows.Forms.Label
    Friend WithEvents txtIssue As System.Windows.Forms.TextBox
    Friend WithEvents lblPriority As System.Windows.Forms.Label
    Friend WithEvents cboPriority As System.Windows.Forms.ComboBox
    Friend WithEvents lblReportedBy As System.Windows.Forms.Label
    Friend WithEvents txtReportedBy As System.Windows.Forms.TextBox
    Friend WithEvents lblDateReported As System.Windows.Forms.Label
    Friend WithEvents dtpDateReported As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblAssignedTo As System.Windows.Forms.Label
    Friend WithEvents txtAssignedTo As System.Windows.Forms.TextBox
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents cboStatus As System.Windows.Forms.ComboBox
    Friend WithEvents lblDateResolved As System.Windows.Forms.Label
    Friend WithEvents dtpDateResolved As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblCost As System.Windows.Forms.Label
    Friend WithEvents numCost As System.Windows.Forms.NumericUpDown
    Friend WithEvents pnlButtons As System.Windows.Forms.Panel
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents lblMode As System.Windows.Forms.Label
    Friend WithEvents pnlTitle As System.Windows.Forms.Panel
    Friend WithEvents lblPageTitle As System.Windows.Forms.Label
    Friend WithEvents pnlTitleStrip As System.Windows.Forms.Panel
    Friend WithEvents pnlTitleAccent As System.Windows.Forms.Panel
End Class
