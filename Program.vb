Imports System.Windows.Forms

Module Program
    <STAThread>
    Public Sub Main()
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)
        Try
            Db.InitDb()
        Catch ex As Exception
            MessageBox.Show("Could not initialise the database: " & ex.Message, "Kisubi Hostel System", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try
        Do
            Dim ok As Boolean
            Using lf As New LoginForm()
                ok = (lf.ShowDialog() = DialogResult.OK)
            End Using
            If Not ok Then Exit Do
            Dim again As Boolean
            Using mf As New MainForm()
                mf.ShowDialog()
                again = mf.LoggedOut
            End Using
            If Not again Then Exit Do
        Loop
    End Sub
End Module
