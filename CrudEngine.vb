Imports System.Data
Imports System.Drawing
Imports System.Globalization
Imports System.Windows.Forms
Imports Microsoft.Data.Sqlite

''' <summary>
''' Adds list / search / add / edit / delete / export behaviour to a designer form.
''' The form owns the controls (so you can move, resize and restyle them in the designer);
''' the engine just binds them to database columns with Bind(...).
''' </summary>
Public Class CrudEngine
    Private ReadOnly _title As String
    Private ReadOnly _table As String
    Private ReadOnly _listSql As String
    Private ReadOnly _grid As DataGridView
    Private ReadOnly _txtSearch As TextBox
    Private ReadOnly _lblMode As Label
    Private ReadOnly _lblCount As Label
    Private ReadOnly _fields As New List(Of FieldDef)
    Private ReadOnly _controls As New Dictionary(Of String, Control)
    Private _dt As DataTable
    Private _currentId As Long = 0
    Private _binding As Boolean = False

    ''' <summary>Optional validation hook. Return "" if OK or an error message. May modify the values.</summary>
    Public BeforeSave As Func(Of Dictionary(Of String, Object), Long, String) = Nothing

    Public Sub New(title As String, table As String, listSql As String, grid As DataGridView,
                   search As TextBox, lblMode As Label, lblCount As Label)
        _title = title
        _table = table
        _listSql = listSql
        _grid = grid
        _txtSearch = search
        _lblMode = lblMode
        _lblCount = lblCount
        Theme.StyleGrid(_grid)
        AddHandler _grid.SelectionChanged, AddressOf Grid_SelectionChanged
        AddHandler _grid.CellFormatting, AddressOf Grid_CellFormatting
        AddHandler _txtSearch.TextChanged, Sub(s, e) ApplyFilter()
    End Sub

    ''' <summary>Link a designer control to a database column. The control type decides the field type.</summary>
    Public Sub Bind(column As String, caption As String, ctl As Control,
                    Optional required As Boolean = False, Optional def As String = "", Optional lookupSql As String = "")
        Dim f As New FieldDef()
        f.Column = column
        f.Caption = caption
        f.Required = required
        f.DefaultValue = def
        f.LookupSql = lookupSql
        f.Kind = InferKind(ctl, lookupSql)
        If f.Kind = FieldKind.Lookup Then
            Dim cb As ComboBox = DirectCast(ctl, ComboBox)
            cb.DropDownStyle = ComboBoxStyle.DropDownList
            cb.DisplayMember = "Text"
            cb.ValueMember = "Id"
            cb.DataSource = Db.Query(lookupSql)
        ElseIf f.Kind = FieldKind.Choice Then
            DirectCast(ctl, ComboBox).DropDownStyle = ComboBoxStyle.DropDownList
        End If
        _fields.Add(f)
        _controls(column) = ctl
    End Sub

    Private Function InferKind(ctl As Control, lookupSql As String) As FieldKind
        If TypeOf ctl Is NumericUpDown Then
            Return If(DirectCast(ctl, NumericUpDown).ThousandsSeparator, FieldKind.Money, FieldKind.Number)
        End If
        If TypeOf ctl Is DateTimePicker Then
            Return If(DirectCast(ctl, DateTimePicker).ShowCheckBox, FieldKind.DateOpt, FieldKind.Dt)
        End If
        If TypeOf ctl Is ComboBox Then
            Return If(lookupSql <> "", FieldKind.Lookup, FieldKind.Choice)
        End If
        Dim t As TextBox = TryCast(ctl, TextBox)
        If t IsNot Nothing Then
            If t.UseSystemPasswordChar Then Return FieldKind.Password
            If t.Multiline Then Return FieldKind.Multiline
        End If
        Return FieldKind.Text
    End Function

    Public Sub Start()
        LoadGrid()
        If _fields.Count > 0 Then ClearForm()
    End Sub

    Public Sub Refresh()
        LoadGrid()
    End Sub

    Public Sub ExportCsv()
        If _dt IsNot Nothing Then Theme.ExportCsv(_dt.DefaultView.ToTable(), _title)
    End Sub

    Public Sub NewRecord()
        _grid.ClearSelection()
        ClearForm()
    End Sub

    Private Sub SetMode(text As String)
        If _lblMode IsNot Nothing Then _lblMode.Text = text
    End Sub

    ' ------------------------------------------------------------------ data
    Private Sub LoadGrid()
        _binding = True
        _dt = Db.Query(_listSql)
        _grid.DataSource = _dt
        If _grid.Columns.Contains("Id") Then _grid.Columns("Id").Width = 55
        _binding = False
        ApplyFilter()
    End Sub

    Private Sub ApplyFilter()
        If _dt Is Nothing Then Return
        _binding = True
        Dim t As String = _txtSearch.Text.Trim().Replace("'", "''").Replace("[", "").Replace("]", "").Replace("*", "").Replace("%", "")
        If t = "" Then
            _dt.DefaultView.RowFilter = ""
        Else
            Dim parts As New List(Of String)
            For Each col As DataColumn In _dt.Columns
                If col.DataType Is GetType(String) Then parts.Add("[" & col.ColumnName & "] LIKE '%" & t & "%'")
            Next
            _dt.DefaultView.RowFilter = String.Join(" OR ", parts)
        End If
        _binding = False
        If _lblCount IsNot Nothing Then _lblCount.Text = "  " & _dt.DefaultView.Count & " record(s)"
    End Sub

    Private Sub Grid_SelectionChanged(sender As Object, e As EventArgs)
        If _binding OrElse _fields.Count = 0 Then Return
        If _grid.SelectedRows.Count = 0 Then Return
        Dim v As Object = _grid.SelectedRows(0).Cells("Id").Value
        If v Is Nothing OrElse IsDBNull(v) Then Return
        LoadRecord(Convert.ToInt64(v))
    End Sub

    Private Sub Grid_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs)
        If e.RowIndex < 0 OrElse e.Value Is Nothing Then Return
        Dim n As String = _grid.Columns(e.ColumnIndex).Name
        If n <> "Status" AndAlso n <> "Condition" AndAlso n <> "Priority" Then Return
        If _grid.Rows(e.RowIndex).Selected Then Return
        Dim bad As String() = {"Open", "Pending", "Unpaid", "Rejected", "Damaged", "Poor", "Suspended", "Inside", "High", "Urgent", "Disabled", "Under Maintenance", "Dismissed", "Waitlist", "Left", "Terminated"}
        e.CellStyle.Font = Theme.FontBold
        If Array.IndexOf(bad, e.Value.ToString()) >= 0 Then
            e.CellStyle.ForeColor = Theme.Maroon
        Else
            e.CellStyle.ForeColor = Theme.Navy
        End If
    End Sub

    Private Function ResolveDefault(f As FieldDef) As String
        Select Case f.DefaultValue
            Case "{now}" : Return DateTime.Now.ToString("HH:mm")
            Case "{user}" : Return Db.CurrentName
            Case "{year}" : Return Theme.CurrentAcademicYear()
            Case Else : Return f.DefaultValue
        End Select
    End Function

    Private Sub ClearForm()
        _currentId = 0
        For Each f As FieldDef In _fields
            Dim c As Control = _controls(f.Column)
            Select Case f.Kind
                Case FieldKind.Number, FieldKind.Money
                    Dim n As NumericUpDown = DirectCast(c, NumericUpDown)
                    Dim d As Decimal = 0
                    Decimal.TryParse(f.DefaultValue, NumberStyles.Any, CultureInfo.InvariantCulture, d)
                    n.Value = Math.Min(Math.Max(d, n.Minimum), n.Maximum)
                Case FieldKind.Dt
                    Dim dv As DateTime
                    If DateTime.TryParse(f.DefaultValue, CultureInfo.InvariantCulture, DateTimeStyles.None, dv) Then
                        DirectCast(c, DateTimePicker).Value = dv
                    Else
                        DirectCast(c, DateTimePicker).Value = Date.Today
                    End If
                Case FieldKind.DateOpt
                    Dim p As DateTimePicker = DirectCast(c, DateTimePicker)
                    p.Value = Date.Today
                    p.Checked = False
                Case FieldKind.Choice
                    Dim cb As ComboBox = DirectCast(c, ComboBox)
                    Dim idx As Integer = cb.FindStringExact(f.DefaultValue)
                    If idx < 0 AndAlso cb.Items.Count > 0 Then idx = 0
                    cb.SelectedIndex = idx
                Case FieldKind.Lookup
                    DirectCast(c, ComboBox).SelectedIndex = -1
                Case Else
                    c.Text = ResolveDefault(f)
            End Select
        Next
        SetMode("NEW RECORD")
    End Sub

    Private Sub LoadRecord(id As Long)
        Dim dt As DataTable = Db.Query("SELECT * FROM " & _table & " WHERE Id=@p0", id)
        If dt.Rows.Count = 0 Then Return
        Dim r As DataRow = dt.Rows(0)
        _currentId = id
        For Each f As FieldDef In _fields
            SetValue(f, r(f.Column))
        Next
        SetMode("EDITING RECORD #" & id)
    End Sub

    Private Sub SetValue(f As FieldDef, val As Object)
        Dim c As Control = _controls(f.Column)
        Dim s As String = If(val Is Nothing OrElse IsDBNull(val), "", Convert.ToString(val, CultureInfo.InvariantCulture))
        Select Case f.Kind
            Case FieldKind.Number, FieldKind.Money
                Dim n As NumericUpDown = DirectCast(c, NumericUpDown)
                Dim d As Decimal = 0
                If Not Decimal.TryParse(s, NumberStyles.Any, CultureInfo.InvariantCulture, d) Then d = 0
                n.Value = Math.Min(Math.Max(d, n.Minimum), n.Maximum)
            Case FieldKind.Dt, FieldKind.DateOpt
                Dim p As DateTimePicker = DirectCast(c, DateTimePicker)
                Dim dv As DateTime
                If DateTime.TryParse(s, CultureInfo.InvariantCulture, DateTimeStyles.None, dv) Then
                    p.Value = dv
                    If f.Kind = FieldKind.DateOpt Then p.Checked = True
                Else
                    p.Value = Date.Today
                    If f.Kind = FieldKind.DateOpt Then p.Checked = False
                End If
            Case FieldKind.Choice
                Dim cb As ComboBox = DirectCast(c, ComboBox)
                cb.SelectedIndex = cb.FindStringExact(s)
            Case FieldKind.Lookup
                Dim cb As ComboBox = DirectCast(c, ComboBox)
                cb.SelectedIndex = -1
                For i As Integer = 0 To cb.Items.Count - 1
                    Dim drv As DataRowView = TryCast(cb.Items(i), DataRowView)
                    If drv IsNot Nothing AndAlso Convert.ToString(drv("Id"), CultureInfo.InvariantCulture) = s Then
                        cb.SelectedIndex = i
                        Exit For
                    End If
                Next
            Case FieldKind.Password
                c.Text = ""
            Case Else
                c.Text = s
        End Select
    End Sub

    Private Function GetValue(f As FieldDef) As Object
        Dim c As Control = _controls(f.Column)
        Select Case f.Kind
            Case FieldKind.Number
                Return CLng(DirectCast(c, NumericUpDown).Value)
            Case FieldKind.Money
                Return CDbl(DirectCast(c, NumericUpDown).Value)
            Case FieldKind.Dt
                Return Theme.Iso(DirectCast(c, DateTimePicker).Value)
            Case FieldKind.DateOpt
                Dim p As DateTimePicker = DirectCast(c, DateTimePicker)
                If p.Checked Then Return Theme.Iso(p.Value)
                Return ""
            Case FieldKind.Choice
                Dim cb As ComboBox = DirectCast(c, ComboBox)
                If cb.SelectedIndex < 0 Then Return ""
                Return cb.Text
            Case FieldKind.Lookup
                Dim drv As DataRowView = TryCast(DirectCast(c, ComboBox).SelectedItem, DataRowView)
                If drv Is Nothing Then Return DBNull.Value
                Return Convert.ToInt64(drv("Id"))
            Case FieldKind.Password
                Return c.Text
            Case Else
                Return c.Text.Trim()
        End Select
    End Function

    Private Sub Warn(msg As String)
        MessageBox.Show(msg, "University of Kisubi Hostel System", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub

    Public Sub Save()
        Dim d As New Dictionary(Of String, Object)
        For Each f As FieldDef In _fields
            Dim v As Object = GetValue(f)
            If f.Required Then
                Dim empty As Boolean = (v Is Nothing) OrElse IsDBNull(v) OrElse (TypeOf v Is String AndAlso CStr(v) = "")
                If empty AndAlso Not (f.Kind = FieldKind.Password AndAlso _currentId > 0) Then
                    Warn(f.Caption & " is required.")
                    _controls(f.Column).Focus()
                    Return
                End If
            End If
            d(f.Column) = v
        Next

        If BeforeSave IsNot Nothing Then
            Dim msg As String = BeforeSave(d, _currentId)
            If Not String.IsNullOrEmpty(msg) Then
                Warn(msg)
                Return
            End If
        End If

        Dim cols As New List(Of String)
        Dim vals As New List(Of Object)
        For Each f As FieldDef In _fields
            Dim v As Object = d(f.Column)
            If f.Kind = FieldKind.Password Then
                If CStr(v) = "" Then Continue For
                v = Db.Hash(CStr(v))
            End If
            cols.Add(f.Column)
            vals.Add(v)
        Next

        Try
            If _currentId = 0 Then
                Dim ph As New List(Of String)
                For i As Integer = 0 To cols.Count - 1
                    ph.Add("@p" & i)
                Next
                Db.Execute("INSERT INTO " & _table & " (" & String.Join(",", cols) & ") VALUES (" & String.Join(",", ph) & ")", vals.ToArray())
                Db.LogAction("Added", _title & ": " & Summary(d))
            Else
                Dim sets As New List(Of String)
                For i As Integer = 0 To cols.Count - 1
                    sets.Add(cols(i) & "=@p" & i)
                Next
                vals.Add(_currentId)
                Db.Execute("UPDATE " & _table & " SET " & String.Join(",", sets) & " WHERE Id=@p" & cols.Count, vals.ToArray())
                Db.LogAction("Updated", _title & " #" & _currentId & ": " & Summary(d))
            End If
        Catch ex As SqliteException
            If ex.Message.Contains("UNIQUE") Then
                Warn("A record with the same unique value already exists (for example the same Registration No, Room No, Receipt No or Username).")
            Else
                Warn("Could not save: " & ex.Message)
            End If
            Return
        End Try

        _txtSearch.Text = ""
        LoadGrid()
        _grid.ClearSelection()
        ClearForm()
        SetMode("SAVED SUCCESSFULLY - NEW RECORD")
    End Sub

    Private Function Summary(d As Dictionary(Of String, Object)) As String
        For Each f As FieldDef In _fields
            If f.Kind = FieldKind.Text AndAlso d.ContainsKey(f.Column) AndAlso CStr(d(f.Column)) <> "" Then Return CStr(d(f.Column))
        Next
        Return ""
    End Function

    Public Sub DeleteSelected()
        If _currentId = 0 Then
            Warn("Select a record from the list first.")
            Return
        End If
        If MessageBox.Show("Delete record #" & _currentId & "? This cannot be undone.", "Confirm delete",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then Return
        Try
            Db.Execute("DELETE FROM " & _table & " WHERE Id=@p0", _currentId)
            Db.LogAction("Deleted", _title & " #" & _currentId)
        Catch ex As Exception
            Warn("Could not delete: " & ex.Message)
            Return
        End Try
        LoadGrid()
        _grid.ClearSelection()
        ClearForm()
    End Sub
End Class
