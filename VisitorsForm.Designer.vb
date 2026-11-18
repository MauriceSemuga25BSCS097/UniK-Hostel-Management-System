<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VisitorsForm
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
        Me.lblVisitorName = New System.Windows.Forms.Label()
        Me.txtVisitorName = New System.Windows.Forms.TextBox()
        Me.lblIDNumber = New System.Windows.Forms.Label()
        Me.txtIDNumber = New System.Windows.Forms.TextBox()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.lblStudentId = New System.Windows.Forms.Label()
        Me.cboStudentId = New System.Windows.Forms.ComboBox()
        Me.lblPurpose = New System.Windows.Forms.Label()
        Me.txtPurpose = New System.Windows.Forms.TextBox()
        Me.lblVisitDate = New System.Windows.Forms.Label()
        Me.dtpVisitDate = New System.Windows.Forms.DateTimePicker()
        Me.lblTimeIn = New System.Windows.Forms.Label()
        Me.txtTimeIn = New System.Windows.Forms.TextBox()
        Me.lblTimeOut = New System.Windows.Forms.Label()
        Me.txtTimeOut = New System.Windows.Forms.TextBox()
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
        Me.pnlFields.Controls.Add(Me.lblVisitorName)
        Me.pnlFields.Controls.Add(Me.txtVisitorName)
        Me.pnlFields.Controls.Add(Me.lblIDNumber)
        Me.pnlFields.Controls.Add(Me.txtIDNumber)
        Me.pnlFields.Controls.Add(Me.lblPhone)
        Me.pnlFields.Controls.Add(Me.txtPhone)
        Me.pnlFields.Controls.Add(Me.lblStudentId)
        Me.pnlFields.Controls.Add(Me.cboStudentId)
        Me.pnlFields.Controls.Add(Me.lblPurpose)
        Me.pnlFields.Controls.Add(Me.txtPurpose)
        Me.pnlFields.Controls.Add(Me.lblVisitDate)
        Me.pnlFields.Controls.Add(Me.dtpVisitDate)
        Me.pnlFields.Controls.Add(Me.lblTimeIn)
        Me.pnlFields.Controls.Add(Me.txtTimeIn)
        Me.pnlFields.Controls.Add(Me.lblTimeOut)
        Me.pnlFields.Controls.Add(Me.txtTimeOut)
        '
        'lblVisitorName
        '
        Me.lblVisitorName.AutoSize = True
        Me.lblVisitorName.Location = New System.Drawing.Point(6, 6)
        Me.lblVisitorName.Text = "Visitor Name *"
        Me.lblVisitorName.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVisitorName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.lblVisitorName.Name = "lblVisitorName"
        Me.lblVisitorName.TabIndex = 0
        '
        'txtVisitorName
        '
        Me.txtVisitorName.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVisitorName.Location = New System.Drawing.Point(8, 30)
        Me.txtVisitorName.Size = New System.Drawing.Size(365, 29)
        Me.txtVisitorName.Name = "txtVisitorName"
        Me.txtVisitorName.TabIndex = 1
        '
        'lblIDNumber
        '
        Me.lblIDNumber.AutoSize = True
        Me.lblIDNumber.Location = New System.Drawing.Point(6, 71)
        Me.lblIDNumber.Text = "ID / Passport No."
        Me.lblIDNumber.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIDNumber.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.lblIDNumber.Name = "lblIDNumber"
        Me.lblIDNumber.TabIndex = 2
        '
        'txtIDNumber
        '
        Me.txtIDNumber.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIDNumber.Location = New System.Drawing.Point(8, 95)
        Me.txtIDNumber.Size = New System.Drawing.Size(365, 29)
        Me.txtIDNumber.Name = "txtIDNumber"
        Me.txtIDNumber.TabIndex = 3
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Location = New System.Drawing.Point(6, 136)
        Me.lblPhone.Text = "Visitor Phone"
        Me.lblPhone.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhone.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.TabIndex = 4
        '
        'txtPhone
        '
        Me.txtPhone.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhone.Location = New System.Drawing.Point(8, 160)
        Me.txtPhone.Size = New System.Drawing.Size(365, 29)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.TabIndex = 5
        '
        'lblStudentId
        '
        Me.lblStudentId.AutoSize = True
        Me.lblStudentId.Location = New System.Drawing.Point(6, 201)
        Me.lblStudentId.Text = "Student Visited *"
        Me.lblStudentId.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentId.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.lblStudentId.Name = "lblStudentId"
        Me.lblStudentId.TabIndex = 6
        '
        'cboStudentId
        '
        Me.cboStudentId.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboStudentId.Location = New System.Drawing.Point(8, 225)
        Me.cboStudentId.Size = New System.Drawing.Size(365, 29)
        Me.cboStudentId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStudentId.FormattingEnabled = True
        Me.cboStudentId.Name = "cboStudentId"
        Me.cboStudentId.TabIndex = 7
        '
        'lblPurpose
        '
        Me.lblPurpose.AutoSize = True
        Me.lblPurpose.Location = New System.Drawing.Point(6, 266)
        Me.lblPurpose.Text = "Purpose of Visit"
        Me.lblPurpose.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPurpose.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.lblPurpose.Name = "lblPurpose"
        Me.lblPurpose.TabIndex = 8
        '
        'txtPurpose
        '
        Me.txtPurpose.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPurpose.Location = New System.Drawing.Point(8, 290)
        Me.txtPurpose.Size = New System.Drawing.Size(365, 29)
        Me.txtPurpose.Name = "txtPurpose"
        Me.txtPurpose.TabIndex = 9
        '
        'lblVisitDate
        '
        Me.lblVisitDate.AutoSize = True
        Me.lblVisitDate.Location = New System.Drawing.Point(6, 331)
        Me.lblVisitDate.Text = "Date"
        Me.lblVisitDate.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVisitDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.lblVisitDate.Name = "lblVisitDate"
        Me.lblVisitDate.TabIndex = 10
        '
        'dtpVisitDate
        '
        Me.dtpVisitDate.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpVisitDate.Location = New System.Drawing.Point(8, 355)
        Me.dtpVisitDate.Size = New System.Drawing.Size(365, 29)
        Me.dtpVisitDate.CustomFormat = "dd MMM yyyy"
        Me.dtpVisitDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpVisitDate.Name = "dtpVisitDate"
        Me.dtpVisitDate.TabIndex = 11
        '
        'lblTimeIn
        '
        Me.lblTimeIn.AutoSize = True
        Me.lblTimeIn.Location = New System.Drawing.Point(6, 396)
        Me.lblTimeIn.Text = "Time In (HH:mm)"
        Me.lblTimeIn.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeIn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.lblTimeIn.Name = "lblTimeIn"
        Me.lblTimeIn.TabIndex = 12
        '
        'txtTimeIn
        '
        Me.txtTimeIn.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTimeIn.Location = New System.Drawing.Point(8, 420)
        Me.txtTimeIn.Size = New System.Drawing.Size(365, 29)
        Me.txtTimeIn.Name = "txtTimeIn"
        Me.txtTimeIn.TabIndex = 13
        '
        'lblTimeOut
        '
        Me.lblTimeOut.AutoSize = True
        Me.lblTimeOut.Location = New System.Drawing.Point(6, 461)
        Me.lblTimeOut.Text = "Time Out (HH:mm) - fill when visitor leaves"
        Me.lblTimeOut.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeOut.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.lblTimeOut.Name = "lblTimeOut"
        Me.lblTimeOut.TabIndex = 14
        '
        'txtTimeOut
        '
        Me.txtTimeOut.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTimeOut.Location = New System.Drawing.Point(8, 485)
        Me.txtTimeOut.Size = New System.Drawing.Size(365, 29)
        Me.txtTimeOut.Name = "txtTimeOut"
        Me.txtTimeOut.TabIndex = 15
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
        Me.lblPageTitle.Text = "Visitors Log"
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
        'VisitorsForm
        '
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1100, 700)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text = "Visitors Log"
        Me.Controls.Add(Me.pnlRight)
        Me.Controls.Add(Me.pnlLeft)
        Me.Controls.Add(Me.pnlTitle)
        Me.Name = "VisitorsForm"
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
    Friend WithEvents lblVisitorName As System.Windows.Forms.Label
    Friend WithEvents txtVisitorName As System.Windows.Forms.TextBox
    Friend WithEvents lblIDNumber As System.Windows.Forms.Label
    Friend WithEvents txtIDNumber As System.Windows.Forms.TextBox
    Friend WithEvents lblPhone As System.Windows.Forms.Label
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents lblStudentId As System.Windows.Forms.Label
    Friend WithEvents cboStudentId As System.Windows.Forms.ComboBox
    Friend WithEvents lblPurpose As System.Windows.Forms.Label
    Friend WithEvents txtPurpose As System.Windows.Forms.TextBox
    Friend WithEvents lblVisitDate As System.Windows.Forms.Label
    Friend WithEvents dtpVisitDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblTimeIn As System.Windows.Forms.Label
    Friend WithEvents txtTimeIn As System.Windows.Forms.TextBox
    Friend WithEvents lblTimeOut As System.Windows.Forms.Label
    Friend WithEvents txtTimeOut As System.Windows.Forms.TextBox
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
