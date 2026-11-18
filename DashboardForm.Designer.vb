<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardForm
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
        Me.pnlOccupancy = New System.Windows.Forms.Panel()
        Me.pnlNotices = New System.Windows.Forms.Panel()
        Me.lstNotices = New System.Windows.Forms.ListBox()
        Me.lblNoticeHead = New System.Windows.Forms.Label()
        Me.flowCards = New System.Windows.Forms.FlowLayoutPanel()
        Me.cardStudents = New System.Windows.Forms.Panel()
        Me.lblStudentsValue = New System.Windows.Forms.Label()
        Me.lblStudentsCaption = New System.Windows.Forms.Label()
        Me.barStudents = New System.Windows.Forms.Panel()
        Me.cardHostels = New System.Windows.Forms.Panel()
        Me.lblHostelsValue = New System.Windows.Forms.Label()
        Me.lblHostelsCaption = New System.Windows.Forms.Label()
        Me.barHostels = New System.Windows.Forms.Panel()
        Me.cardBeds = New System.Windows.Forms.Panel()
        Me.lblBedsValue = New System.Windows.Forms.Label()
        Me.lblBedsCaption = New System.Windows.Forms.Label()
        Me.barBeds = New System.Windows.Forms.Panel()
        Me.cardOccupied = New System.Windows.Forms.Panel()
        Me.lblOccupiedValue = New System.Windows.Forms.Label()
        Me.lblOccupiedCaption = New System.Windows.Forms.Label()
        Me.barOccupied = New System.Windows.Forms.Panel()
        Me.cardFree = New System.Windows.Forms.Panel()
        Me.lblFreeValue = New System.Windows.Forms.Label()
        Me.lblFreeCaption = New System.Windows.Forms.Label()
        Me.barFree = New System.Windows.Forms.Panel()
        Me.cardFees = New System.Windows.Forms.Panel()
        Me.lblFeesValue = New System.Windows.Forms.Label()
        Me.lblFeesCaption = New System.Windows.Forms.Label()
        Me.barFees = New System.Windows.Forms.Panel()
        Me.cardFines = New System.Windows.Forms.Panel()
        Me.lblFinesValue = New System.Windows.Forms.Label()
        Me.lblFinesCaption = New System.Windows.Forms.Label()
        Me.barFines = New System.Windows.Forms.Panel()
        Me.cardApplications = New System.Windows.Forms.Panel()
        Me.lblApplicationsValue = New System.Windows.Forms.Label()
        Me.lblApplicationsCaption = New System.Windows.Forms.Label()
        Me.barApplications = New System.Windows.Forms.Panel()
        Me.cardRepairs = New System.Windows.Forms.Panel()
        Me.lblRepairsValue = New System.Windows.Forms.Label()
        Me.lblRepairsCaption = New System.Windows.Forms.Label()
        Me.barRepairs = New System.Windows.Forms.Panel()
        Me.cardVisitors = New System.Windows.Forms.Panel()
        Me.lblVisitorsValue = New System.Windows.Forms.Label()
        Me.lblVisitorsCaption = New System.Windows.Forms.Label()
        Me.barVisitors = New System.Windows.Forms.Panel()
        Me.cardExeat = New System.Windows.Forms.Panel()
        Me.lblExeatValue = New System.Windows.Forms.Label()
        Me.lblExeatCaption = New System.Windows.Forms.Label()
        Me.barExeat = New System.Windows.Forms.Panel()
        Me.cardComplaints = New System.Windows.Forms.Panel()
        Me.lblComplaintsValue = New System.Windows.Forms.Label()
        Me.lblComplaintsCaption = New System.Windows.Forms.Label()
        Me.barComplaints = New System.Windows.Forms.Panel()
        Me.pnlTitle = New System.Windows.Forms.Panel()
        Me.lblPageTitle = New System.Windows.Forms.Label()
        Me.pnlTitleStrip = New System.Windows.Forms.Panel()
        Me.pnlTitleAccent = New System.Windows.Forms.Panel()
        Me.pnlOccupancy.SuspendLayout()
        Me.pnlNotices.SuspendLayout()
        Me.flowCards.SuspendLayout()
        Me.cardStudents.SuspendLayout()
        Me.barStudents.SuspendLayout()
        Me.cardHostels.SuspendLayout()
        Me.barHostels.SuspendLayout()
        Me.cardBeds.SuspendLayout()
        Me.barBeds.SuspendLayout()
        Me.cardOccupied.SuspendLayout()
        Me.barOccupied.SuspendLayout()
        Me.cardFree.SuspendLayout()
        Me.barFree.SuspendLayout()
        Me.cardFees.SuspendLayout()
        Me.barFees.SuspendLayout()
        Me.cardFines.SuspendLayout()
        Me.barFines.SuspendLayout()
        Me.cardApplications.SuspendLayout()
        Me.barApplications.SuspendLayout()
        Me.cardRepairs.SuspendLayout()
        Me.barRepairs.SuspendLayout()
        Me.cardVisitors.SuspendLayout()
        Me.barVisitors.SuspendLayout()
        Me.cardExeat.SuspendLayout()
        Me.barExeat.SuspendLayout()
        Me.cardComplaints.SuspendLayout()
        Me.barComplaints.SuspendLayout()
        Me.pnlTitle.SuspendLayout()
        Me.pnlTitleStrip.SuspendLayout()
        Me.pnlTitleAccent.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlOccupancy
        '
        Me.pnlOccupancy.BackColor = System.Drawing.Color.White
        Me.pnlOccupancy.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlOccupancy.Size = New System.Drawing.Size(700, 300)
        Me.pnlOccupancy.Name = "pnlOccupancy"
        Me.pnlOccupancy.TabIndex = 0
        '
        'pnlNotices
        '
        Me.pnlNotices.BackColor = System.Drawing.Color.White
        Me.pnlNotices.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlNotices.Padding = New System.Windows.Forms.Padding(14, 14, 14, 14)
        Me.pnlNotices.Size = New System.Drawing.Size(380, 300)
        Me.pnlNotices.Name = "pnlNotices"
        Me.pnlNotices.TabIndex = 1
        Me.pnlNotices.Controls.Add(Me.lstNotices)
        Me.pnlNotices.Controls.Add(Me.lblNoticeHead)
        '
        'lstNotices
        '
        Me.lstNotices.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstNotices.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstNotices.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstNotices.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.lstNotices.FormattingEnabled = True
        Me.lstNotices.IntegralHeight = False
        Me.lstNotices.ItemHeight = 19
        Me.lstNotices.Name = "lstNotices"
        Me.lstNotices.TabIndex = 0
        '
        'lblNoticeHead
        '
        Me.lblNoticeHead.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblNoticeHead.Font = New System.Drawing.Font("Segoe UI", 13!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoticeHead.ForeColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.lblNoticeHead.Size = New System.Drawing.Size(352, 34)
        Me.lblNoticeHead.Text = "Latest Notices"
        Me.lblNoticeHead.Name = "lblNoticeHead"
        Me.lblNoticeHead.TabIndex = 1
        '
        'flowCards
        '
        Me.flowCards.AutoScroll = True
        Me.flowCards.Dock = System.Windows.Forms.DockStyle.Top
        Me.flowCards.Padding = New System.Windows.Forms.Padding(10, 6, 10, 0)
        Me.flowCards.Size = New System.Drawing.Size(1100, 250)
        Me.flowCards.Name = "flowCards"
        Me.flowCards.TabIndex = 2
        Me.flowCards.Controls.Add(Me.cardStudents)
        Me.flowCards.Controls.Add(Me.cardHostels)
        Me.flowCards.Controls.Add(Me.cardBeds)
        Me.flowCards.Controls.Add(Me.cardOccupied)
        Me.flowCards.Controls.Add(Me.cardFree)
        Me.flowCards.Controls.Add(Me.cardFees)
        Me.flowCards.Controls.Add(Me.cardFines)
        Me.flowCards.Controls.Add(Me.cardApplications)
        Me.flowCards.Controls.Add(Me.cardRepairs)
        Me.flowCards.Controls.Add(Me.cardVisitors)
        Me.flowCards.Controls.Add(Me.cardExeat)
        Me.flowCards.Controls.Add(Me.cardComplaints)
        '
        'cardStudents
        '
        Me.cardStudents.BackColor = System.Drawing.Color.White
        Me.cardStudents.Margin = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.cardStudents.Size = New System.Drawing.Size(205, 92)
        Me.cardStudents.Name = "cardStudents"
        Me.cardStudents.TabIndex = 0
        Me.cardStudents.Controls.Add(Me.lblStudentsValue)
        Me.cardStudents.Controls.Add(Me.lblStudentsCaption)
        Me.cardStudents.Controls.Add(Me.barStudents)
        '
        'lblStudentsValue
        '
        Me.lblStudentsValue.Font = New System.Drawing.Font("Segoe UI", 20!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentsValue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.lblStudentsValue.Location = New System.Drawing.Point(18, 8)
        Me.lblStudentsValue.Size = New System.Drawing.Size(182, 42)
        Me.lblStudentsValue.Text = "0"
        Me.lblStudentsValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblStudentsValue.Name = "lblStudentsValue"
        Me.lblStudentsValue.TabIndex = 0
        '
        'lblStudentsCaption
        '
        Me.lblStudentsCaption.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentsCaption.ForeColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.lblStudentsCaption.Location = New System.Drawing.Point(18, 54)
        Me.lblStudentsCaption.Size = New System.Drawing.Size(182, 30)
        Me.lblStudentsCaption.Text = "Active Students"
        Me.lblStudentsCaption.Name = "lblStudentsCaption"
        Me.lblStudentsCaption.TabIndex = 1
        '
        'barStudents
        '
        Me.barStudents.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.barStudents.Dock = System.Windows.Forms.DockStyle.Left
        Me.barStudents.Size = New System.Drawing.Size(8, 92)
        Me.barStudents.Name = "barStudents"
        Me.barStudents.TabIndex = 2
        '
        'cardHostels
        '
        Me.cardHostels.BackColor = System.Drawing.Color.White
        Me.cardHostels.Margin = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.cardHostels.Size = New System.Drawing.Size(205, 92)
        Me.cardHostels.Name = "cardHostels"
        Me.cardHostels.TabIndex = 1
        Me.cardHostels.Controls.Add(Me.lblHostelsValue)
        Me.cardHostels.Controls.Add(Me.lblHostelsCaption)
        Me.cardHostels.Controls.Add(Me.barHostels)
        '
        'lblHostelsValue
        '
        Me.lblHostelsValue.Font = New System.Drawing.Font("Segoe UI", 20!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHostelsValue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.lblHostelsValue.Location = New System.Drawing.Point(18, 8)
        Me.lblHostelsValue.Size = New System.Drawing.Size(182, 42)
        Me.lblHostelsValue.Text = "0"
        Me.lblHostelsValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblHostelsValue.Name = "lblHostelsValue"
        Me.lblHostelsValue.TabIndex = 0
        '
        'lblHostelsCaption
        '
        Me.lblHostelsCaption.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHostelsCaption.ForeColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.lblHostelsCaption.Location = New System.Drawing.Point(18, 54)
        Me.lblHostelsCaption.Size = New System.Drawing.Size(182, 30)
        Me.lblHostelsCaption.Text = "Hostels"
        Me.lblHostelsCaption.Name = "lblHostelsCaption"
        Me.lblHostelsCaption.TabIndex = 1
        '
        'barHostels
        '
        Me.barHostels.BackColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.barHostels.Dock = System.Windows.Forms.DockStyle.Left
        Me.barHostels.Size = New System.Drawing.Size(8, 92)
        Me.barHostels.Name = "barHostels"
        Me.barHostels.TabIndex = 2
        '
        'cardBeds
        '
        Me.cardBeds.BackColor = System.Drawing.Color.White
        Me.cardBeds.Margin = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.cardBeds.Size = New System.Drawing.Size(205, 92)
        Me.cardBeds.Name = "cardBeds"
        Me.cardBeds.TabIndex = 2
        Me.cardBeds.Controls.Add(Me.lblBedsValue)
        Me.cardBeds.Controls.Add(Me.lblBedsCaption)
        Me.cardBeds.Controls.Add(Me.barBeds)
        '
        'lblBedsValue
        '
        Me.lblBedsValue.Font = New System.Drawing.Font("Segoe UI", 20!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBedsValue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.lblBedsValue.Location = New System.Drawing.Point(18, 8)
        Me.lblBedsValue.Size = New System.Drawing.Size(182, 42)
        Me.lblBedsValue.Text = "0"
        Me.lblBedsValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblBedsValue.Name = "lblBedsValue"
        Me.lblBedsValue.TabIndex = 0
        '
        'lblBedsCaption
        '
        Me.lblBedsCaption.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBedsCaption.ForeColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.lblBedsCaption.Location = New System.Drawing.Point(18, 54)
        Me.lblBedsCaption.Size = New System.Drawing.Size(182, 30)
        Me.lblBedsCaption.Text = "Total Beds"
        Me.lblBedsCaption.Name = "lblBedsCaption"
        Me.lblBedsCaption.TabIndex = 1
        '
        'barBeds
        '
        Me.barBeds.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.barBeds.Dock = System.Windows.Forms.DockStyle.Left
        Me.barBeds.Size = New System.Drawing.Size(8, 92)
        Me.barBeds.Name = "barBeds"
        Me.barBeds.TabIndex = 2
        '
        'cardOccupied
        '
        Me.cardOccupied.BackColor = System.Drawing.Color.White
        Me.cardOccupied.Margin = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.cardOccupied.Size = New System.Drawing.Size(205, 92)
        Me.cardOccupied.Name = "cardOccupied"
        Me.cardOccupied.TabIndex = 3
        Me.cardOccupied.Controls.Add(Me.lblOccupiedValue)
        Me.cardOccupied.Controls.Add(Me.lblOccupiedCaption)
        Me.cardOccupied.Controls.Add(Me.barOccupied)
        '
        'lblOccupiedValue
        '
        Me.lblOccupiedValue.Font = New System.Drawing.Font("Segoe UI", 20!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOccupiedValue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.lblOccupiedValue.Location = New System.Drawing.Point(18, 8)
        Me.lblOccupiedValue.Size = New System.Drawing.Size(182, 42)
        Me.lblOccupiedValue.Text = "0"
        Me.lblOccupiedValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblOccupiedValue.Name = "lblOccupiedValue"
        Me.lblOccupiedValue.TabIndex = 0
        '
        'lblOccupiedCaption
        '
        Me.lblOccupiedCaption.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOccupiedCaption.ForeColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.lblOccupiedCaption.Location = New System.Drawing.Point(18, 54)
        Me.lblOccupiedCaption.Size = New System.Drawing.Size(182, 30)
        Me.lblOccupiedCaption.Text = "Occupied Beds"
        Me.lblOccupiedCaption.Name = "lblOccupiedCaption"
        Me.lblOccupiedCaption.TabIndex = 1
        '
        'barOccupied
        '
        Me.barOccupied.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.barOccupied.Dock = System.Windows.Forms.DockStyle.Left
        Me.barOccupied.Size = New System.Drawing.Size(8, 92)
        Me.barOccupied.Name = "barOccupied"
        Me.barOccupied.TabIndex = 2
        '
        'cardFree
        '
        Me.cardFree.BackColor = System.Drawing.Color.White
        Me.cardFree.Margin = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.cardFree.Size = New System.Drawing.Size(205, 92)
        Me.cardFree.Name = "cardFree"
        Me.cardFree.TabIndex = 4
        Me.cardFree.Controls.Add(Me.lblFreeValue)
        Me.cardFree.Controls.Add(Me.lblFreeCaption)
        Me.cardFree.Controls.Add(Me.barFree)
        '
        'lblFreeValue
        '
        Me.lblFreeValue.Font = New System.Drawing.Font("Segoe UI", 20!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFreeValue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.lblFreeValue.Location = New System.Drawing.Point(18, 8)
        Me.lblFreeValue.Size = New System.Drawing.Size(182, 42)
        Me.lblFreeValue.Text = "0"
        Me.lblFreeValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblFreeValue.Name = "lblFreeValue"
        Me.lblFreeValue.TabIndex = 0
        '
        'lblFreeCaption
        '
        Me.lblFreeCaption.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFreeCaption.ForeColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.lblFreeCaption.Location = New System.Drawing.Point(18, 54)
        Me.lblFreeCaption.Size = New System.Drawing.Size(182, 30)
        Me.lblFreeCaption.Text = "Free Beds"
        Me.lblFreeCaption.Name = "lblFreeCaption"
        Me.lblFreeCaption.TabIndex = 1
        '
        'barFree
        '
        Me.barFree.BackColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.barFree.Dock = System.Windows.Forms.DockStyle.Left
        Me.barFree.Size = New System.Drawing.Size(8, 92)
        Me.barFree.Name = "barFree"
        Me.barFree.TabIndex = 2
        '
        'cardFees
        '
        Me.cardFees.BackColor = System.Drawing.Color.White
        Me.cardFees.Margin = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.cardFees.Size = New System.Drawing.Size(205, 92)
        Me.cardFees.Name = "cardFees"
        Me.cardFees.TabIndex = 5
        Me.cardFees.Controls.Add(Me.lblFeesValue)
        Me.cardFees.Controls.Add(Me.lblFeesCaption)
        Me.cardFees.Controls.Add(Me.barFees)
        '
        'lblFeesValue
        '
        Me.lblFeesValue.Font = New System.Drawing.Font("Segoe UI", 20!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFeesValue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.lblFeesValue.Location = New System.Drawing.Point(18, 8)
        Me.lblFeesValue.Size = New System.Drawing.Size(182, 42)
        Me.lblFeesValue.Text = "0"
        Me.lblFeesValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblFeesValue.Name = "lblFeesValue"
        Me.lblFeesValue.TabIndex = 0
        '
        'lblFeesCaption
        '
        Me.lblFeesCaption.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFeesCaption.ForeColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.lblFeesCaption.Location = New System.Drawing.Point(18, 54)
        Me.lblFeesCaption.Size = New System.Drawing.Size(182, 30)
        Me.lblFeesCaption.Text = "Fees Collected This Month"
        Me.lblFeesCaption.Name = "lblFeesCaption"
        Me.lblFeesCaption.TabIndex = 1
        '
        'barFees
        '
        Me.barFees.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.barFees.Dock = System.Windows.Forms.DockStyle.Left
        Me.barFees.Size = New System.Drawing.Size(8, 92)
        Me.barFees.Name = "barFees"
        Me.barFees.TabIndex = 2
        '
        'cardFines
        '
        Me.cardFines.BackColor = System.Drawing.Color.White
        Me.cardFines.Margin = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.cardFines.Size = New System.Drawing.Size(205, 92)
        Me.cardFines.Name = "cardFines"
        Me.cardFines.TabIndex = 6
        Me.cardFines.Controls.Add(Me.lblFinesValue)
        Me.cardFines.Controls.Add(Me.lblFinesCaption)
        Me.cardFines.Controls.Add(Me.barFines)
        '
        'lblFinesValue
        '
        Me.lblFinesValue.Font = New System.Drawing.Font("Segoe UI", 20!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinesValue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.lblFinesValue.Location = New System.Drawing.Point(18, 8)
        Me.lblFinesValue.Size = New System.Drawing.Size(182, 42)
        Me.lblFinesValue.Text = "0"
        Me.lblFinesValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblFinesValue.Name = "lblFinesValue"
        Me.lblFinesValue.TabIndex = 0
        '
        'lblFinesCaption
        '
        Me.lblFinesCaption.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinesCaption.ForeColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.lblFinesCaption.Location = New System.Drawing.Point(18, 54)
        Me.lblFinesCaption.Size = New System.Drawing.Size(182, 30)
        Me.lblFinesCaption.Text = "Unpaid Fines"
        Me.lblFinesCaption.Name = "lblFinesCaption"
        Me.lblFinesCaption.TabIndex = 1
        '
        'barFines
        '
        Me.barFines.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.barFines.Dock = System.Windows.Forms.DockStyle.Left
        Me.barFines.Size = New System.Drawing.Size(8, 92)
        Me.barFines.Name = "barFines"
        Me.barFines.TabIndex = 2
        '
        'cardApplications
        '
        Me.cardApplications.BackColor = System.Drawing.Color.White
        Me.cardApplications.Margin = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.cardApplications.Size = New System.Drawing.Size(205, 92)
        Me.cardApplications.Name = "cardApplications"
        Me.cardApplications.TabIndex = 7
        Me.cardApplications.Controls.Add(Me.lblApplicationsValue)
        Me.cardApplications.Controls.Add(Me.lblApplicationsCaption)
        Me.cardApplications.Controls.Add(Me.barApplications)
        '
        'lblApplicationsValue
        '
        Me.lblApplicationsValue.Font = New System.Drawing.Font("Segoe UI", 20!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApplicationsValue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.lblApplicationsValue.Location = New System.Drawing.Point(18, 8)
        Me.lblApplicationsValue.Size = New System.Drawing.Size(182, 42)
        Me.lblApplicationsValue.Text = "0"
        Me.lblApplicationsValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblApplicationsValue.Name = "lblApplicationsValue"
        Me.lblApplicationsValue.TabIndex = 0
        '
        'lblApplicationsCaption
        '
        Me.lblApplicationsCaption.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApplicationsCaption.ForeColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.lblApplicationsCaption.Location = New System.Drawing.Point(18, 54)
        Me.lblApplicationsCaption.Size = New System.Drawing.Size(182, 30)
        Me.lblApplicationsCaption.Text = "Pending Room Applications"
        Me.lblApplicationsCaption.Name = "lblApplicationsCaption"
        Me.lblApplicationsCaption.TabIndex = 1
        '
        'barApplications
        '
        Me.barApplications.BackColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.barApplications.Dock = System.Windows.Forms.DockStyle.Left
        Me.barApplications.Size = New System.Drawing.Size(8, 92)
        Me.barApplications.Name = "barApplications"
        Me.barApplications.TabIndex = 2
        '
        'cardRepairs
        '
        Me.cardRepairs.BackColor = System.Drawing.Color.White
        Me.cardRepairs.Margin = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.cardRepairs.Size = New System.Drawing.Size(205, 92)
        Me.cardRepairs.Name = "cardRepairs"
        Me.cardRepairs.TabIndex = 8
        Me.cardRepairs.Controls.Add(Me.lblRepairsValue)
        Me.cardRepairs.Controls.Add(Me.lblRepairsCaption)
        Me.cardRepairs.Controls.Add(Me.barRepairs)
        '
        'lblRepairsValue
        '
        Me.lblRepairsValue.Font = New System.Drawing.Font("Segoe UI", 20!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRepairsValue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.lblRepairsValue.Location = New System.Drawing.Point(18, 8)
        Me.lblRepairsValue.Size = New System.Drawing.Size(182, 42)
        Me.lblRepairsValue.Text = "0"
        Me.lblRepairsValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblRepairsValue.Name = "lblRepairsValue"
        Me.lblRepairsValue.TabIndex = 0
        '
        'lblRepairsCaption
        '
        Me.lblRepairsCaption.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRepairsCaption.ForeColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.lblRepairsCaption.Location = New System.Drawing.Point(18, 54)
        Me.lblRepairsCaption.Size = New System.Drawing.Size(182, 30)
        Me.lblRepairsCaption.Text = "Open Repair Requests"
        Me.lblRepairsCaption.Name = "lblRepairsCaption"
        Me.lblRepairsCaption.TabIndex = 1
        '
        'barRepairs
        '
        Me.barRepairs.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.barRepairs.Dock = System.Windows.Forms.DockStyle.Left
        Me.barRepairs.Size = New System.Drawing.Size(8, 92)
        Me.barRepairs.Name = "barRepairs"
        Me.barRepairs.TabIndex = 2
        '
        'cardVisitors
        '
        Me.cardVisitors.BackColor = System.Drawing.Color.White
        Me.cardVisitors.Margin = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.cardVisitors.Size = New System.Drawing.Size(205, 92)
        Me.cardVisitors.Name = "cardVisitors"
        Me.cardVisitors.TabIndex = 9
        Me.cardVisitors.Controls.Add(Me.lblVisitorsValue)
        Me.cardVisitors.Controls.Add(Me.lblVisitorsCaption)
        Me.cardVisitors.Controls.Add(Me.barVisitors)
        '
        'lblVisitorsValue
        '
        Me.lblVisitorsValue.Font = New System.Drawing.Font("Segoe UI", 20!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVisitorsValue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.lblVisitorsValue.Location = New System.Drawing.Point(18, 8)
        Me.lblVisitorsValue.Size = New System.Drawing.Size(182, 42)
        Me.lblVisitorsValue.Text = "0"
        Me.lblVisitorsValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblVisitorsValue.Name = "lblVisitorsValue"
        Me.lblVisitorsValue.TabIndex = 0
        '
        'lblVisitorsCaption
        '
        Me.lblVisitorsCaption.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVisitorsCaption.ForeColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.lblVisitorsCaption.Location = New System.Drawing.Point(18, 54)
        Me.lblVisitorsCaption.Size = New System.Drawing.Size(182, 30)
        Me.lblVisitorsCaption.Text = "Visitors Inside Now"
        Me.lblVisitorsCaption.Name = "lblVisitorsCaption"
        Me.lblVisitorsCaption.TabIndex = 1
        '
        'barVisitors
        '
        Me.barVisitors.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.barVisitors.Dock = System.Windows.Forms.DockStyle.Left
        Me.barVisitors.Size = New System.Drawing.Size(8, 92)
        Me.barVisitors.Name = "barVisitors"
        Me.barVisitors.TabIndex = 2
        '
        'cardExeat
        '
        Me.cardExeat.BackColor = System.Drawing.Color.White
        Me.cardExeat.Margin = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.cardExeat.Size = New System.Drawing.Size(205, 92)
        Me.cardExeat.Name = "cardExeat"
        Me.cardExeat.TabIndex = 10
        Me.cardExeat.Controls.Add(Me.lblExeatValue)
        Me.cardExeat.Controls.Add(Me.lblExeatCaption)
        Me.cardExeat.Controls.Add(Me.barExeat)
        '
        'lblExeatValue
        '
        Me.lblExeatValue.Font = New System.Drawing.Font("Segoe UI", 20!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExeatValue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.lblExeatValue.Location = New System.Drawing.Point(18, 8)
        Me.lblExeatValue.Size = New System.Drawing.Size(182, 42)
        Me.lblExeatValue.Text = "0"
        Me.lblExeatValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblExeatValue.Name = "lblExeatValue"
        Me.lblExeatValue.TabIndex = 0
        '
        'lblExeatCaption
        '
        Me.lblExeatCaption.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExeatCaption.ForeColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.lblExeatCaption.Location = New System.Drawing.Point(18, 54)
        Me.lblExeatCaption.Size = New System.Drawing.Size(182, 30)
        Me.lblExeatCaption.Text = "Pending Exeat Requests"
        Me.lblExeatCaption.Name = "lblExeatCaption"
        Me.lblExeatCaption.TabIndex = 1
        '
        'barExeat
        '
        Me.barExeat.BackColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.barExeat.Dock = System.Windows.Forms.DockStyle.Left
        Me.barExeat.Size = New System.Drawing.Size(8, 92)
        Me.barExeat.Name = "barExeat"
        Me.barExeat.TabIndex = 2
        '
        'cardComplaints
        '
        Me.cardComplaints.BackColor = System.Drawing.Color.White
        Me.cardComplaints.Margin = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.cardComplaints.Size = New System.Drawing.Size(205, 92)
        Me.cardComplaints.Name = "cardComplaints"
        Me.cardComplaints.TabIndex = 11
        Me.cardComplaints.Controls.Add(Me.lblComplaintsValue)
        Me.cardComplaints.Controls.Add(Me.lblComplaintsCaption)
        Me.cardComplaints.Controls.Add(Me.barComplaints)
        '
        'lblComplaintsValue
        '
        Me.lblComplaintsValue.Font = New System.Drawing.Font("Segoe UI", 20!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComplaintsValue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.lblComplaintsValue.Location = New System.Drawing.Point(18, 8)
        Me.lblComplaintsValue.Size = New System.Drawing.Size(182, 42)
        Me.lblComplaintsValue.Text = "0"
        Me.lblComplaintsValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblComplaintsValue.Name = "lblComplaintsValue"
        Me.lblComplaintsValue.TabIndex = 0
        '
        'lblComplaintsCaption
        '
        Me.lblComplaintsCaption.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComplaintsCaption.ForeColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.lblComplaintsCaption.Location = New System.Drawing.Point(18, 54)
        Me.lblComplaintsCaption.Size = New System.Drawing.Size(182, 30)
        Me.lblComplaintsCaption.Text = "Open Complaints"
        Me.lblComplaintsCaption.Name = "lblComplaintsCaption"
        Me.lblComplaintsCaption.TabIndex = 1
        '
        'barComplaints
        '
        Me.barComplaints.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.barComplaints.Dock = System.Windows.Forms.DockStyle.Left
        Me.barComplaints.Size = New System.Drawing.Size(8, 92)
        Me.barComplaints.Name = "barComplaints"
        Me.barComplaints.TabIndex = 2
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
        Me.lblPageTitle.Text = "Dashboard"
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
        'DashboardForm
        '
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1100, 700)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text = "Dashboard"
        Me.Controls.Add(Me.pnlOccupancy)
        Me.Controls.Add(Me.pnlNotices)
        Me.Controls.Add(Me.flowCards)
        Me.Controls.Add(Me.pnlTitle)
        Me.Name = "DashboardForm"
        Me.pnlTitleAccent.ResumeLayout(False)
        Me.pnlTitleAccent.PerformLayout()
        Me.pnlTitleStrip.ResumeLayout(False)
        Me.pnlTitleStrip.PerformLayout()
        Me.pnlTitle.ResumeLayout(False)
        Me.pnlTitle.PerformLayout()
        Me.barComplaints.ResumeLayout(False)
        Me.barComplaints.PerformLayout()
        Me.cardComplaints.ResumeLayout(False)
        Me.cardComplaints.PerformLayout()
        Me.barExeat.ResumeLayout(False)
        Me.barExeat.PerformLayout()
        Me.cardExeat.ResumeLayout(False)
        Me.cardExeat.PerformLayout()
        Me.barVisitors.ResumeLayout(False)
        Me.barVisitors.PerformLayout()
        Me.cardVisitors.ResumeLayout(False)
        Me.cardVisitors.PerformLayout()
        Me.barRepairs.ResumeLayout(False)
        Me.barRepairs.PerformLayout()
        Me.cardRepairs.ResumeLayout(False)
        Me.cardRepairs.PerformLayout()
        Me.barApplications.ResumeLayout(False)
        Me.barApplications.PerformLayout()
        Me.cardApplications.ResumeLayout(False)
        Me.cardApplications.PerformLayout()
        Me.barFines.ResumeLayout(False)
        Me.barFines.PerformLayout()
        Me.cardFines.ResumeLayout(False)
        Me.cardFines.PerformLayout()
        Me.barFees.ResumeLayout(False)
        Me.barFees.PerformLayout()
        Me.cardFees.ResumeLayout(False)
        Me.cardFees.PerformLayout()
        Me.barFree.ResumeLayout(False)
        Me.barFree.PerformLayout()
        Me.cardFree.ResumeLayout(False)
        Me.cardFree.PerformLayout()
        Me.barOccupied.ResumeLayout(False)
        Me.barOccupied.PerformLayout()
        Me.cardOccupied.ResumeLayout(False)
        Me.cardOccupied.PerformLayout()
        Me.barBeds.ResumeLayout(False)
        Me.barBeds.PerformLayout()
        Me.cardBeds.ResumeLayout(False)
        Me.cardBeds.PerformLayout()
        Me.barHostels.ResumeLayout(False)
        Me.barHostels.PerformLayout()
        Me.cardHostels.ResumeLayout(False)
        Me.cardHostels.PerformLayout()
        Me.barStudents.ResumeLayout(False)
        Me.barStudents.PerformLayout()
        Me.cardStudents.ResumeLayout(False)
        Me.cardStudents.PerformLayout()
        Me.flowCards.ResumeLayout(False)
        Me.flowCards.PerformLayout()
        Me.pnlNotices.ResumeLayout(False)
        Me.pnlNotices.PerformLayout()
        Me.pnlOccupancy.ResumeLayout(False)
        Me.pnlOccupancy.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlOccupancy As System.Windows.Forms.Panel
    Friend WithEvents pnlNotices As System.Windows.Forms.Panel
    Friend WithEvents lstNotices As System.Windows.Forms.ListBox
    Friend WithEvents lblNoticeHead As System.Windows.Forms.Label
    Friend WithEvents flowCards As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents cardStudents As System.Windows.Forms.Panel
    Friend WithEvents lblStudentsValue As System.Windows.Forms.Label
    Friend WithEvents lblStudentsCaption As System.Windows.Forms.Label
    Friend WithEvents barStudents As System.Windows.Forms.Panel
    Friend WithEvents cardHostels As System.Windows.Forms.Panel
    Friend WithEvents lblHostelsValue As System.Windows.Forms.Label
    Friend WithEvents lblHostelsCaption As System.Windows.Forms.Label
    Friend WithEvents barHostels As System.Windows.Forms.Panel
    Friend WithEvents cardBeds As System.Windows.Forms.Panel
    Friend WithEvents lblBedsValue As System.Windows.Forms.Label
    Friend WithEvents lblBedsCaption As System.Windows.Forms.Label
    Friend WithEvents barBeds As System.Windows.Forms.Panel
    Friend WithEvents cardOccupied As System.Windows.Forms.Panel
    Friend WithEvents lblOccupiedValue As System.Windows.Forms.Label
    Friend WithEvents lblOccupiedCaption As System.Windows.Forms.Label
    Friend WithEvents barOccupied As System.Windows.Forms.Panel
    Friend WithEvents cardFree As System.Windows.Forms.Panel
    Friend WithEvents lblFreeValue As System.Windows.Forms.Label
    Friend WithEvents lblFreeCaption As System.Windows.Forms.Label
    Friend WithEvents barFree As System.Windows.Forms.Panel
    Friend WithEvents cardFees As System.Windows.Forms.Panel
    Friend WithEvents lblFeesValue As System.Windows.Forms.Label
    Friend WithEvents lblFeesCaption As System.Windows.Forms.Label
    Friend WithEvents barFees As System.Windows.Forms.Panel
    Friend WithEvents cardFines As System.Windows.Forms.Panel
    Friend WithEvents lblFinesValue As System.Windows.Forms.Label
    Friend WithEvents lblFinesCaption As System.Windows.Forms.Label
    Friend WithEvents barFines As System.Windows.Forms.Panel
    Friend WithEvents cardApplications As System.Windows.Forms.Panel
    Friend WithEvents lblApplicationsValue As System.Windows.Forms.Label
    Friend WithEvents lblApplicationsCaption As System.Windows.Forms.Label
    Friend WithEvents barApplications As System.Windows.Forms.Panel
    Friend WithEvents cardRepairs As System.Windows.Forms.Panel
    Friend WithEvents lblRepairsValue As System.Windows.Forms.Label
    Friend WithEvents lblRepairsCaption As System.Windows.Forms.Label
    Friend WithEvents barRepairs As System.Windows.Forms.Panel
    Friend WithEvents cardVisitors As System.Windows.Forms.Panel
    Friend WithEvents lblVisitorsValue As System.Windows.Forms.Label
    Friend WithEvents lblVisitorsCaption As System.Windows.Forms.Label
    Friend WithEvents barVisitors As System.Windows.Forms.Panel
    Friend WithEvents cardExeat As System.Windows.Forms.Panel
    Friend WithEvents lblExeatValue As System.Windows.Forms.Label
    Friend WithEvents lblExeatCaption As System.Windows.Forms.Label
    Friend WithEvents barExeat As System.Windows.Forms.Panel
    Friend WithEvents cardComplaints As System.Windows.Forms.Panel
    Friend WithEvents lblComplaintsValue As System.Windows.Forms.Label
    Friend WithEvents lblComplaintsCaption As System.Windows.Forms.Label
    Friend WithEvents barComplaints As System.Windows.Forms.Panel
    Friend WithEvents pnlTitle As System.Windows.Forms.Panel
    Friend WithEvents lblPageTitle As System.Windows.Forms.Label
    Friend WithEvents pnlTitleStrip As System.Windows.Forms.Panel
    Friend WithEvents pnlTitleAccent As System.Windows.Forms.Panel
End Class
