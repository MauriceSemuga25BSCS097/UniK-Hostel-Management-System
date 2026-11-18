Imports System.Drawing
Imports System.Windows.Forms
Public Class StudentsForm
    Private _engine As CrudEngine

    Public Sub New()
        InitializeComponent()
        Theme.MakeEmbedded(Me)
    End Sub

    Private Sub StudentsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _engine = New CrudEngine("Students", "Students", "SELECT Id, RegNo AS [Reg No], FullName AS [Full Name], Gender, Faculty, Course, YearOfStudy AS [Year], Phone, Status FROM Students ORDER BY FullName", dgv, txtSearch, lblMode, lblCount)
        _engine.Bind("RegNo", "Registration No.", txtRegNo, True)
        _engine.Bind("FullName", "Full Name", txtFullName, True)
        _engine.Bind("Gender", "Gender", cboGender, True)
        _engine.Bind("DOB", "Date of Birth", dtpDOB, False, "2004-01-01")
        _engine.Bind("Nationality", "Nationality", txtNationality, False, "Ugandan")
        _engine.Bind("Faculty", "Faculty / School", txtFaculty)
        _engine.Bind("Course", "Course / Programme", txtCourse)
        _engine.Bind("YearOfStudy", "Year of Study", numYearOfStudy, False, "1")
        _engine.Bind("Phone", "Phone", txtPhone)
        _engine.Bind("Email", "Email", txtEmail)
        _engine.Bind("HomeAddress", "Home Address", txtHomeAddress)
        _engine.Bind("NextOfKin", "Next of Kin", txtNextOfKin)
        _engine.Bind("NextOfKinPhone", "Next of Kin Phone", txtNextOfKinPhone)
        _engine.Bind("Status", "Status", cboStatus, True)
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
