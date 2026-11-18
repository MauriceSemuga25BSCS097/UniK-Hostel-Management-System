Imports System.Data
Imports System.Drawing
Imports System.IO
Imports System.Text
Imports System.ComponentModel
Imports System.Windows.Forms

''' <summary>University of Kisubi colour theme: Maroon, Dark Navy Blue, Mustard Yellow.</summary>
Public Module Theme
    Public ReadOnly Maroon As Color = Color.FromArgb(122, 31, 43)
    Public ReadOnly MaroonDark As Color = Color.FromArgb(92, 20, 30)
    Public ReadOnly Navy As Color = Color.FromArgb(11, 31, 75)
    Public ReadOnly NavyLight As Color = Color.FromArgb(28, 58, 120)
    Public ReadOnly Mustard As Color = Color.FromArgb(228, 169, 19)
    Public ReadOnly Cream As Color = Color.FromArgb(251, 247, 234)
    Public ReadOnly Muted As Color = Color.FromArgb(90, 90, 110)

    Public ReadOnly FontBase As New Font("Segoe UI", 10.5F)
    Public ReadOnly FontBold As New Font("Segoe UI", 10.5F, FontStyle.Bold)
    Public ReadOnly FontTitle As New Font("Segoe UI", 18F, FontStyle.Bold)
    Public ReadOnly FontH2 As New Font("Segoe UI", 13F, FontStyle.Bold)
    Public ReadOnly FontBig As New Font("Segoe UI", 20F, FontStyle.Bold)

    Public Function CurrentAcademicYear() As String
        Dim y As Integer = Date.Today.Year
        If Date.Today.Month < 8 Then y -= 1
        Return y & "/" & (y + 1)
    End Function

    Public Function Iso(d As DateTime) As String
        Return d.ToString("yyyy-MM-dd", Globalization.CultureInfo.InvariantCulture)
    End Function

    Public Function LoadLogo() As Image
        Try
            Dim p As String = Path.Combine(AppContext.BaseDirectory, "logo.png")
            If File.Exists(p) Then
                Using img As Image = Image.FromFile(p)
                    Return New Bitmap(img)
                End Using
            End If
        Catch
        End Try
        Return Nothing
    End Function

    Public Function MakeButton(text As String, kind As String, Optional width As Integer = 120) As Button
        Dim b As New Button()
        b.Text = text
        b.Width = width
        b.Height = 40
        b.FlatStyle = FlatStyle.Flat
        b.Cursor = Cursors.Hand
        b.Font = FontBold
        b.Margin = New Padding(3)
        b.FlatAppearance.BorderSize = 0
        Select Case kind
            Case "accent"
                b.BackColor = Mustard
                b.ForeColor = Navy
                b.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 190, 50)
            Case "navy"
                b.BackColor = Navy
                b.ForeColor = Color.White
                b.FlatAppearance.MouseOverBackColor = NavyLight
            Case Else
                b.BackColor = Maroon
                b.ForeColor = Color.White
                b.FlatAppearance.MouseOverBackColor = MaroonDark
        End Select
        Return b
    End Function

    ''' <summary>Makes a designer form behave as a docked panel inside the main window (skipped in the VS designer).</summary>
    Public Sub MakeEmbedded(f As Form)
        If LicenseManager.UsageMode = LicenseUsageMode.Designtime Then Return
        f.TopLevel = False
        f.FormBorderStyle = FormBorderStyle.None
        f.Dock = DockStyle.Fill
    End Sub

    Public Function MakeTitleBar(title As String) As Panel
        Dim p As New Panel()
        p.Dock = DockStyle.Top
        p.Height = 64
        p.BackColor = Color.White
        Dim lbl As New Label()
        lbl.Text = title
        lbl.Font = FontTitle
        lbl.ForeColor = Navy
        lbl.Dock = DockStyle.Fill
        lbl.TextAlign = ContentAlignment.MiddleLeft
        lbl.Padding = New Padding(18, 0, 0, 0)
        Dim strip As New Panel()
        strip.Dock = DockStyle.Bottom
        strip.Height = 4
        strip.BackColor = Mustard
        Dim accent As New Panel()
        accent.Dock = DockStyle.Left
        accent.Width = 8
        accent.BackColor = Maroon
        p.Controls.Add(lbl)
        p.Controls.Add(strip)
        p.Controls.Add(accent)
        Return p
    End Function

    Public Sub StyleGrid(g As DataGridView)
        g.BorderStyle = BorderStyle.None
        g.BackgroundColor = Color.White
        g.EnableHeadersVisualStyles = False
        g.ColumnHeadersDefaultCellStyle.BackColor = Navy
        g.ColumnHeadersDefaultCellStyle.ForeColor = Mustard
        g.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 10.5F, FontStyle.Bold)
        g.ColumnHeadersDefaultCellStyle.SelectionBackColor = Navy
        g.ColumnHeadersHeight = 42
        g.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        g.DefaultCellStyle.Font = FontBase
        g.DefaultCellStyle.ForeColor = Color.FromArgb(25, 25, 45)
        g.DefaultCellStyle.SelectionBackColor = Maroon
        g.DefaultCellStyle.SelectionForeColor = Color.White
        g.AlternatingRowsDefaultCellStyle.BackColor = Cream
        g.GridColor = Color.FromArgb(230, 222, 200)
        g.RowTemplate.Height = 32
        g.ReadOnly = True
        g.AllowUserToAddRows = False
        g.AllowUserToDeleteRows = False
        g.AllowUserToResizeRows = False
        g.RowHeadersVisible = False
        g.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        g.MultiSelect = False
        g.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    End Sub

    Public Sub ExportCsv(dt As DataTable, baseName As String)
        Using dlg As New SaveFileDialog()
            dlg.Filter = "CSV file (opens in Excel)|*.csv"
            dlg.FileName = baseName.Replace(" ", "_") & "_" & DateTime.Now.ToString("yyyyMMdd_HHmm")
            If dlg.ShowDialog() <> DialogResult.OK Then Return
            Dim sb As New StringBuilder()
            Dim heads As New List(Of String)
            For Each c As DataColumn In dt.Columns
                heads.Add(Csv(c.ColumnName))
            Next
            sb.AppendLine(String.Join(",", heads))
            For Each r As DataRow In dt.Rows
                Dim cells As New List(Of String)
                For Each c As DataColumn In dt.Columns
                    cells.Add(Csv(Convert.ToString(r(c))))
                Next
                sb.AppendLine(String.Join(",", cells))
            Next
            File.WriteAllText(dlg.FileName, sb.ToString(), New UTF8Encoding(True))
            If MessageBox.Show("Exported " & dt.Rows.Count & " rows." & vbCrLf & "Open the file now?", "Export complete",
                               MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                Try
                    Process.Start(New ProcessStartInfo(dlg.FileName) With {.UseShellExecute = True})
                Catch
                End Try
            End If
        End Using
    End Sub

    Private Function Csv(s As String) As String
        If s Is Nothing Then Return ""
        If s.Contains(",") OrElse s.Contains("""") OrElse s.Contains(vbLf) Then
            Return """" & s.Replace("""", """""") & """"
        End If
        Return s
    End Function
End Module
