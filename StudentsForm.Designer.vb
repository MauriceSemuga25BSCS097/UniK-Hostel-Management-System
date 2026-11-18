<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentsForm
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
        Me.lblRegNo = New System.Windows.Forms.Label()
        Me.txtRegNo = New System.Windows.Forms.TextBox()
        Me.lblFullName = New System.Windows.Forms.Label()
        Me.txtFullName = New System.Windows.Forms.TextBox()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.cboGender = New System.Windows.Forms.ComboBox()
        Me.lblDOB = New System.Windows.Forms.Label()
        Me.dtpDOB = New System.Windows.Forms.DateTimePicker()
        Me.lblNationality = New System.Windows.Forms.Label()
        Me.txtNationality = New System.Windows.Forms.TextBox()
        Me.lblFaculty = New System.Windows.Forms.Label()
        Me.txtFaculty = New System.Windows.Forms.TextBox()
        Me.lblCourse = New System.Windows.Forms.Label()
        Me.txtCourse = New System.Windows.Forms.TextBox()
        Me.lblYearOfStudy = New System.Windows.Forms.Label()
        Me.numYearOfStudy = New System.Windows.Forms.NumericUpDown()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblHomeAddress = New System.Windows.Forms.Label()
        Me.txtHomeAddress = New System.Windows.Forms.TextBox()
        Me.lblNextOfKin = New System.Windows.Forms.Label()
        Me.txtNextOfKin = New System.Windows.Forms.TextBox()
        Me.lblNextOfKinPhone = New System.Windows.Forms.Label()
        Me.txtNextOfKinPhone = New System.Windows.Forms.TextBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.cboStatus = New System.Windows.Forms.ComboBox()
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
        Me.pnlFields.Controls.Add(Me.lblRegNo)
        Me.pnlFields.Controls.Add(Me.txtRegNo)
        Me.pnlFields.Controls.Add(Me.lblFullName)
        Me.pnlFields.Controls.Add(Me.txtFullName)
        Me.pnlFields.Controls.Add(Me.lblGender)
        Me.pnlFields.Controls.Add(Me.cboGender)
        Me.pnlFields.Controls.Add(Me.lblDOB)
        Me.pnlFields.Controls.Add(Me.dtpDOB)
        Me.pnlFields.Controls.Add(Me.lblNationality)
        Me.pnlFields.Controls.Add(Me.txtNationality)
        Me.pnlFields.Controls.Add(Me.lblFaculty)
        Me.pnlFields.Controls.Add(Me.txtFaculty)
        Me.pnlFields.Controls.Add(Me.lblCourse)
        Me.pnlFields.Controls.Add(Me.txtCourse)
        Me.pnlFields.Controls.Add(Me.lblYearOfStudy)
        Me.pnlFields.Controls.Add(Me.numYearOfStudy)
        Me.pnlFields.Controls.Add(Me.lblPhone)
        Me.pnlFields.Controls.Add(Me.txtPhone)
        Me.pnlFields.Controls.Add(Me.lblEmail)
        Me.pnlFields.Controls.Add(Me.txtEmail)
        Me.pnlFields.Controls.Add(Me.lblHomeAddress)
        Me.pnlFields.Controls.Add(Me.txtHomeAddress)
        Me.pnlFields.Controls.Add(Me.lblNextOfKin)
        Me.pnlFields.Controls.Add(Me.txtNextOfKin)
        Me.pnlFields.Controls.Add(Me.lblNextOfKinPhone)
        Me.pnlFields.Controls.Add(Me.txtNextOfKinPhone)
        Me.pnlFields.Controls.Add(Me.lblStatus)
        Me.pnlFields.Controls.Add(Me.cboStatus)
        '
        'lblRegNo
        '
        Me.lblRegNo.AutoSize = True
        Me.lblRegNo.Location = New System.Drawing.Point(6, 6)
        Me.lblRegNo.Text = "Registration No. *"
        Me.lblRegNo.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegNo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.lblRegNo.Name = "lblRegNo"
        Me.lblRegNo.TabIndex = 0
        '
        'txtRegNo
        '
        Me.txtRegNo.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRegNo.Location = New System.Drawing.Point(8, 30)
        Me.txtRegNo.Size = New System.Drawing.Size(365, 29)
        Me.txtRegNo.Name = "txtRegNo"
        Me.txtRegNo.TabIndex = 1
        '
        'lblFullName
        '
        Me.lblFullName.AutoSize = True
        Me.lblFullName.Location = New System.Drawing.Point(6, 71)
        Me.lblFullName.Text = "Full Name *"
        Me.lblFullName.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFullName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.lblFullName.Name = "lblFullName"
        Me.lblFullName.TabIndex = 2
        '
        'txtFullName
        '
        Me.txtFullName.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFullName.Location = New System.Drawing.Point(8, 95)
        Me.txtFullName.Size = New System.Drawing.Size(365, 29)
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.TabIndex = 3
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Location = New System.Drawing.Point(6, 136)
        Me.lblGender.Text = "Gender *"
        Me.lblGender.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGender.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.lblGender.Name = "lblGender"
        Me.lblGender.TabIndex = 4
        '
        'cboGender
        '
        Me.cboGender.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboGender.Location = New System.Drawing.Point(8, 160)
        Me.cboGender.Size = New System.Drawing.Size(365, 29)
        Me.cboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGender.FormattingEnabled = True
        Me.cboGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cboGender.Name = "cboGender"
        Me.cboGender.TabIndex = 5
        '
        'lblDOB
        '
        Me.lblDOB.AutoSize = True
        Me.lblDOB.Location = New System.Drawing.Point(6, 201)
        Me.lblDOB.Text = "Date of Birth"
        Me.lblDOB.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDOB.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.lblDOB.Name = "lblDOB"
        Me.lblDOB.TabIndex = 6
        '
        'dtpDOB
        '
        Me.dtpDOB.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDOB.Location = New System.Drawing.Point(8, 225)
        Me.dtpDOB.Size = New System.Drawing.Size(365, 29)
        Me.dtpDOB.CustomFormat = "dd MMM yyyy"
        Me.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDOB.Name = "dtpDOB"
        Me.dtpDOB.TabIndex = 7
        '
        'lblNationality
        '
        Me.lblNationality.AutoSize = True
        Me.lblNationality.Location = New System.Drawing.Point(6, 266)
        Me.lblNationality.Text = "Nationality"
        Me.lblNationality.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNationality.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.lblNationality.Name = "lblNationality"
        Me.lblNationality.TabIndex = 8
        '
        'txtNationality
        '
        Me.txtNationality.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNationality.Location = New System.Drawing.Point(8, 290)
        Me.txtNationality.Size = New System.Drawing.Size(365, 29)
        Me.txtNationality.Name = "txtNationality"
        Me.txtNationality.TabIndex = 9
        '
        'lblFaculty
        '
        Me.lblFaculty.AutoSize = True
        Me.lblFaculty.Location = New System.Drawing.Point(6, 331)
        Me.lblFaculty.Text = "Faculty / School"
        Me.lblFaculty.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFaculty.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.lblFaculty.Name = "lblFaculty"
        Me.lblFaculty.TabIndex = 10
        '
        'txtFaculty
        '
        Me.txtFaculty.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFaculty.Location = New System.Drawing.Point(8, 355)
        Me.txtFaculty.Size = New System.Drawing.Size(365, 29)
        Me.txtFaculty.Name = "txtFaculty"
        Me.txtFaculty.TabIndex = 11
        '
        'lblCourse
        '
        Me.lblCourse.AutoSize = True
        Me.lblCourse.Location = New System.Drawing.Point(6, 396)
        Me.lblCourse.Text = "Course / Programme"
        Me.lblCourse.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCourse.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.lblCourse.Name = "lblCourse"
        Me.lblCourse.TabIndex = 12
        '
        'txtCourse
        '
        Me.txtCourse.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCourse.Location = New System.Drawing.Point(8, 420)
        Me.txtCourse.Size = New System.Drawing.Size(365, 29)
        Me.txtCourse.Name = "txtCourse"
        Me.txtCourse.TabIndex = 13
        '
        'lblYearOfStudy
        '
        Me.lblYearOfStudy.AutoSize = True
        Me.lblYearOfStudy.Location = New System.Drawing.Point(6, 461)
        Me.lblYearOfStudy.Text = "Year of Study"
        Me.lblYearOfStudy.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYearOfStudy.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.lblYearOfStudy.Name = "lblYearOfStudy"
        Me.lblYearOfStudy.TabIndex = 14
        '
        'numYearOfStudy
        '
        Me.numYearOfStudy.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numYearOfStudy.Location = New System.Drawing.Point(8, 485)
        Me.numYearOfStudy.Size = New System.Drawing.Size(365, 29)
        Me.numYearOfStudy.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.numYearOfStudy.Name = "numYearOfStudy"
        Me.numYearOfStudy.TabIndex = 15
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Location = New System.Drawing.Point(6, 526)
        Me.lblPhone.Text = "Phone"
        Me.lblPhone.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhone.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.TabIndex = 16
        '
        'txtPhone
        '
        Me.txtPhone.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhone.Location = New System.Drawing.Point(8, 550)
        Me.txtPhone.Size = New System.Drawing.Size(365, 29)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.TabIndex = 17
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(6, 591)
        Me.lblEmail.Text = "Email"
        Me.lblEmail.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.TabIndex = 18
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(8, 615)
        Me.txtEmail.Size = New System.Drawing.Size(365, 29)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.TabIndex = 19
        '
        'lblHomeAddress
        '
        Me.lblHomeAddress.AutoSize = True
        Me.lblHomeAddress.Location = New System.Drawing.Point(6, 656)
        Me.lblHomeAddress.Text = "Home Address"
        Me.lblHomeAddress.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHomeAddress.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.lblHomeAddress.Name = "lblHomeAddress"
        Me.lblHomeAddress.TabIndex = 20
        '
        'txtHomeAddress
        '
        Me.txtHomeAddress.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHomeAddress.Location = New System.Drawing.Point(8, 680)
        Me.txtHomeAddress.Size = New System.Drawing.Size(365, 72)
        Me.txtHomeAddress.Multiline = True
        Me.txtHomeAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtHomeAddress.Name = "txtHomeAddress"
        Me.txtHomeAddress.TabIndex = 21
        '
        'lblNextOfKin
        '
        Me.lblNextOfKin.AutoSize = True
        Me.lblNextOfKin.Location = New System.Drawing.Point(6, 764)
        Me.lblNextOfKin.Text = "Next of Kin"
        Me.lblNextOfKin.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNextOfKin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.lblNextOfKin.Name = "lblNextOfKin"
        Me.lblNextOfKin.TabIndex = 22
        '
        'txtNextOfKin
        '
        Me.txtNextOfKin.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNextOfKin.Location = New System.Drawing.Point(8, 788)
        Me.txtNextOfKin.Size = New System.Drawing.Size(365, 29)
        Me.txtNextOfKin.Name = "txtNextOfKin"
        Me.txtNextOfKin.TabIndex = 23
        '
        'lblNextOfKinPhone
        '
        Me.lblNextOfKinPhone.AutoSize = True
        Me.lblNextOfKinPhone.Location = New System.Drawing.Point(6, 829)
        Me.lblNextOfKinPhone.Text = "Next of Kin Phone"
        Me.lblNextOfKinPhone.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNextOfKinPhone.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.lblNextOfKinPhone.Name = "lblNextOfKinPhone"
        Me.lblNextOfKinPhone.TabIndex = 24
        '
        'txtNextOfKinPhone
        '
        Me.txtNextOfKinPhone.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNextOfKinPhone.Location = New System.Drawing.Point(8, 853)
        Me.txtNextOfKinPhone.Size = New System.Drawing.Size(365, 29)
        Me.txtNextOfKinPhone.Name = "txtNextOfKinPhone"
        Me.txtNextOfKinPhone.TabIndex = 25
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(6, 894)
        Me.lblStatus.Text = "Status *"
        Me.lblStatus.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.TabIndex = 26
        '
        'cboStatus
        '
        Me.cboStatus.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboStatus.Location = New System.Drawing.Point(8, 918)
        Me.cboStatus.Size = New System.Drawing.Size(365, 29)
        Me.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.Items.AddRange(New Object() {"Active", "Suspended", "Graduated", "Withdrawn"})
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.TabIndex = 27
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
        Me.lblPageTitle.Text = "Students"
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
        'StudentsForm
        '
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1100, 700)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text = "Students"
        Me.Controls.Add(Me.pnlRight)
        Me.Controls.Add(Me.pnlLeft)
        Me.Controls.Add(Me.pnlTitle)
        Me.Name = "StudentsForm"
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
    Friend WithEvents lblRegNo As System.Windows.Forms.Label
    Friend WithEvents txtRegNo As System.Windows.Forms.TextBox
    Friend WithEvents lblFullName As System.Windows.Forms.Label
    Friend WithEvents txtFullName As System.Windows.Forms.TextBox
    Friend WithEvents lblGender As System.Windows.Forms.Label
    Friend WithEvents cboGender As System.Windows.Forms.ComboBox
    Friend WithEvents lblDOB As System.Windows.Forms.Label
    Friend WithEvents dtpDOB As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblNationality As System.Windows.Forms.Label
    Friend WithEvents txtNationality As System.Windows.Forms.TextBox
    Friend WithEvents lblFaculty As System.Windows.Forms.Label
    Friend WithEvents txtFaculty As System.Windows.Forms.TextBox
    Friend WithEvents lblCourse As System.Windows.Forms.Label
    Friend WithEvents txtCourse As System.Windows.Forms.TextBox
    Friend WithEvents lblYearOfStudy As System.Windows.Forms.Label
    Friend WithEvents numYearOfStudy As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblPhone As System.Windows.Forms.Label
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents lblHomeAddress As System.Windows.Forms.Label
    Friend WithEvents txtHomeAddress As System.Windows.Forms.TextBox
    Friend WithEvents lblNextOfKin As System.Windows.Forms.Label
    Friend WithEvents txtNextOfKin As System.Windows.Forms.TextBox
    Friend WithEvents lblNextOfKinPhone As System.Windows.Forms.Label
    Friend WithEvents txtNextOfKinPhone As System.Windows.Forms.TextBox
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents cboStatus As System.Windows.Forms.ComboBox
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
