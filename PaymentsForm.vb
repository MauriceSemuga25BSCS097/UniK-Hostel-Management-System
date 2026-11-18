Imports System.Drawing
Imports System.Windows.Forms
Public Class PaymentsForm
    Private _engine As CrudEngine

    Public Sub New()
        InitializeComponent()
        Theme.MakeEmbedded(Me)
    End Sub

    Private Sub PaymentsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _engine = New CrudEngine("Hostel Fees & Payments", "Payments", "SELECT p.Id, p.ReceiptNo AS [Receipt No], s.RegNo AS [Reg No], s.FullName AS Student, p.Purpose, p.Amount, p.PayDate AS [Date], p.Method, p.Semester, p.AcademicYear AS [Academic Year], p.ReceivedBy AS [Received By] FROM Payments p JOIN Students s ON s.Id = p.StudentId ORDER BY p.Id DESC", dgv, txtSearch, lblMode, lblCount)
        _engine.Bind("ReceiptNo", "Receipt No. (blank = auto)", txtReceiptNo)
        _engine.Bind("StudentId", "Student", cboStudentId, True, "", Rules.StudentLk)
        _engine.Bind("Purpose", "Purpose", cboPurpose, True)
        _engine.Bind("Amount", "Amount (UGX)", numAmount, True)
        _engine.Bind("PayDate", "Payment Date", dtpPayDate)
        _engine.Bind("Method", "Method", cboMethod, True)
        _engine.Bind("Reference", "Bank / Mobile Money Reference", txtReference)
        _engine.Bind("Semester", "Semester", cboSemester, True)
        _engine.Bind("AcademicYear", "Academic Year", txtAcademicYear, True, "{year}")
        _engine.Bind("ReceivedBy", "Received By", txtReceivedBy, False, "{user}")
        _engine.BeforeSave = AddressOf Rules.PaymentCheck
        _engine.Start()
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        _engine.ExportCsv()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        _engine.Refresh()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        _engine.Save()
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        _engine.NewRecord()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        _engine.DeleteSelected()
    End Sub
End Class
