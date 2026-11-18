<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RoomsForm
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
        Me.lblRoomNo = New System.Windows.Forms.Label()
        Me.txtRoomNo = New System.Windows.Forms.TextBox()
        Me.lblFloor = New System.Windows.Forms.Label()
        Me.numFloor = New System.Windows.Forms.NumericUpDown()
        Me.lblRoomType = New System.Windows.Forms.Label()
        Me.cboRoomType = New System.Windows.Forms.ComboBox()
        Me.lblCapacity = New System.Windows.Forms.Label()
        Me.numCapacity = New System.Windows.Forms.NumericUpDown()
        Me.lblFeePerSemester = New System.Windows.Forms.Label()
        Me.numFeePerSemester = New System.Windows.Forms.NumericUpDown()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.cboStatus = New System.Windows.Forms.ComboBox()
        Me.lblNotes = New System.Windows.Forms.Label()
        Me.txtNotes = New System.Windows.Forms.TextBox()
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
        Me.pnlFields.Controls.Add(Me.lblRoomNo)
        Me.pnlFields.Controls.Add(Me.txtRoomNo)
        Me.pnlFields.Controls.Add(Me.lblFloor)
        Me.pnlFields.Controls.Add(Me.numFloor)
        Me.pnlFields.Controls.Add(Me.lblRoomType)
        Me.pnlFields.Controls.Add(Me.cboRoomType)
        Me.pnlFields.Controls.Add(Me.lblCapacity)
        Me.pnlFields.Controls.Add(Me.numCapacity)
        Me.pnlFields.Controls.Add(Me.lblFeePerSemester)
        Me.pnlFields.Controls.Add(Me.numFeePerSemester)
        Me.pnlFields.Controls.Add(Me.lblStatus)
        Me.pnlFields.Controls.Add(Me.cboStatus)
        Me.pnlFields.Controls.Add(Me.lblNotes)
        Me.pnlFields.Controls.Add(Me.txtNotes)
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
        'lblRoomNo
        '
        Me.lblRoomNo.AutoSize = True
        Me.lblRoomNo.Location = New System.Drawing.Point(6, 71)
        Me.lblRoomNo.Text = "Room Number *"
        Me.lblRoomNo.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRoomNo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.lblRoomNo.Name = "lblRoomNo"
        Me.lblRoomNo.TabIndex = 2
        '
        'txtRoomNo
        '
        Me.txtRoomNo.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRoomNo.Location = New System.Drawing.Point(8, 95)
        Me.txtRoomNo.Size = New System.Drawing.Size(365, 29)
        Me.txtRoomNo.Name = "txtRoomNo"
        Me.txtRoomNo.TabIndex = 3
        '
        'lblFloor
        '
        Me.lblFloor.AutoSize = True
        Me.lblFloor.Location = New System.Drawing.Point(6, 136)
        Me.lblFloor.Text = "Floor (0 = ground)"
        Me.lblFloor.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFloor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.lblFloor.Name = "lblFloor"
        Me.lblFloor.TabIndex = 4
        '
        'numFloor
        '
        Me.numFloor.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numFloor.Location = New System.Drawing.Point(8, 160)
        Me.numFloor.Size = New System.Drawing.Size(365, 29)
        Me.numFloor.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.numFloor.Name = "numFloor"
        Me.numFloor.TabIndex = 5
        '
        'lblRoomType
        '
        Me.lblRoomType.AutoSize = True
        Me.lblRoomType.Location = New System.Drawing.Point(6, 201)
        Me.lblRoomType.Text = "Room Type *"
        Me.lblRoomType.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRoomType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.lblRoomType.Name = "lblRoomType"
        Me.lblRoomType.TabIndex = 6
        '
        'cboRoomType
        '
        Me.cboRoomType.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboRoomType.Location = New System.Drawing.Point(8, 225)
        Me.cboRoomType.Size = New System.Drawing.Size(365, 29)
        Me.cboRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRoomType.FormattingEnabled = True
        Me.cboRoomType.Items.AddRange(New Object() {"Single", "Double", "Triple", "Quad", "Dormitory"})
        Me.cboRoomType.Name = "cboRoomType"
        Me.cboRoomType.TabIndex = 7
        '
        'lblCapacity
        '
        Me.lblCapacity.AutoSize = True
        Me.lblCapacity.Location = New System.Drawing.Point(6, 266)
        Me.lblCapacity.Text = "Capacity (beds) *"
        Me.lblCapacity.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCapacity.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.lblCapacity.Name = "lblCapacity"
        Me.lblCapacity.TabIndex = 8
        '
        'numCapacity
        '
        Me.numCapacity.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numCapacity.Location = New System.Drawing.Point(8, 290)
        Me.numCapacity.Size = New System.Drawing.Size(365, 29)
        Me.numCapacity.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.numCapacity.Name = "numCapacity"
        Me.numCapacity.TabIndex = 9
        '
        'lblFeePerSemester
        '
        Me.lblFeePerSemester.AutoSize = True
        Me.lblFeePerSemester.Location = New System.Drawing.Point(6, 331)
        Me.lblFeePerSemester.Text = "Fee per Semester (UGX)"
        Me.lblFeePerSemester.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFeePerSemester.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.lblFeePerSemester.Name = "lblFeePerSemester"
        Me.lblFeePerSemester.TabIndex = 10
        '
        'numFeePerSemester
        '
        Me.numFeePerSemester.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numFeePerSemester.Location = New System.Drawing.Point(8, 355)
        Me.numFeePerSemester.Size = New System.Drawing.Size(365, 29)
        Me.numFeePerSemester.Increment = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.numFeePerSemester.Maximum = New Decimal(New Integer() {1000000000, 0, 0, 0})
        Me.numFeePerSemester.ThousandsSeparator = True
        Me.numFeePerSemester.Name = "numFeePerSemester"
        Me.numFeePerSemester.TabIndex = 11
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(6, 396)
        Me.lblStatus.Text = "Status *"
        Me.lblStatus.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.TabIndex = 12
        '
        'cboStatus
        '
        Me.cboStatus.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboStatus.Location = New System.Drawing.Point(8, 420)
        Me.cboStatus.Size = New System.Drawing.Size(365, 29)
        Me.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.Items.AddRange(New Object() {"Available", "Under Maintenance"})
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.TabIndex = 13
        '
        'lblNotes
        '
        Me.lblNotes.AutoSize = True
        Me.lblNotes.Location = New System.Drawing.Point(6, 461)
        Me.lblNotes.Text = "Notes"
        Me.lblNotes.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNotes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.lblNotes.Name = "lblNotes"
        Me.lblNotes.TabIndex = 14
        '
        'txtNotes
        '
        Me.txtNotes.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNotes.Location = New System.Drawing.Point(8, 485)
        Me.txtNotes.Size = New System.Drawing.Size(365, 72)
        Me.txtNotes.Multiline = True
        Me.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.TabIndex = 15
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
        Me.lblPageTitle.Text = "Rooms & Beds"
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
        'RoomsForm
        '
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1100, 700)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text = "Rooms & Beds"
        Me.Controls.Add(Me.pnlRight)
        Me.Controls.Add(Me.pnlLeft)
        Me.Controls.Add(Me.pnlTitle)
        Me.Name = "RoomsForm"
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
    Friend WithEvents lblRoomNo As System.Windows.Forms.Label
    Friend WithEvents txtRoomNo As System.Windows.Forms.TextBox
    Friend WithEvents lblFloor As System.Windows.Forms.Label
    Friend WithEvents numFloor As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblRoomType As System.Windows.Forms.Label
    Friend WithEvents cboRoomType As System.Windows.Forms.ComboBox
    Friend WithEvents lblCapacity As System.Windows.Forms.Label
    Friend WithEvents numCapacity As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblFeePerSemester As System.Windows.Forms.Label
    Friend WithEvents numFeePerSemester As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents cboStatus As System.Windows.Forms.ComboBox
    Friend WithEvents lblNotes As System.Windows.Forms.Label
    Friend WithEvents txtNotes As System.Windows.Forms.TextBox
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
