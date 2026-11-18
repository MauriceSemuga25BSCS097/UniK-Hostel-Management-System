Imports System.Data
Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
Imports Microsoft.Data.Sqlite

''' <summary>SQLite data access. The database file is created automatically next to the .exe.</summary>
Public Module Db
    Public ReadOnly DbPath As String = Path.Combine(AppContext.BaseDirectory, "kisubi_hostel.db")

    Public CurrentUser As String = ""
    Public CurrentName As String = ""
    Public CurrentRole As String = ""

    Private Function Open() As SqliteConnection
        Dim c As New SqliteConnection("Data Source=" & DbPath)
        c.Open()
        Return c
    End Function

    Private Sub AddParams(cmd As SqliteCommand, args() As Object)
        If args Is Nothing Then Return
        For i As Integer = 0 To args.Length - 1
            Dim v As Object = args(i)
            If v Is Nothing Then v = DBNull.Value
            cmd.Parameters.AddWithValue("@p" & i, v)
        Next
    End Sub

    Public Function Query(sql As String, ParamArray args() As Object) As DataTable
        ' Read everything first, then choose each column's type from its real values.
        ' (SQLite columns built from expressions have no declared type, which makes
        ' DataTable.Load guess wrongly - e.g. an image column - and breaks the grids.)
        Dim names As New List(Of String)
        Dim rows As New List(Of Object())
        Using c As SqliteConnection = Open()
            Using cmd As SqliteCommand = c.CreateCommand()
                cmd.CommandText = sql
                AddParams(cmd, args)
                Using r As SqliteDataReader = cmd.ExecuteReader()
                    For i As Integer = 0 To r.FieldCount - 1
                        names.Add(r.GetName(i))
                    Next
                    While r.Read()
                        Dim vals(r.FieldCount - 1) As Object
                        r.GetValues(vals)
                        rows.Add(vals)
                    End While
                End Using
            End Using
        End Using

        Dim dt As New DataTable()
        For i As Integer = 0 To names.Count - 1
            Dim anyValue As Boolean = False
            Dim allInt As Boolean = True
            Dim allNum As Boolean = True
            For Each rw As Object() In rows
                Dim v As Object = rw(i)
                If v Is Nothing OrElse IsDBNull(v) Then Continue For
                anyValue = True
                If Not TypeOf v Is Long Then allInt = False
                If Not (TypeOf v Is Long OrElse TypeOf v Is Double) Then allNum = False
            Next
            Dim t As Type = GetType(String)
            If anyValue AndAlso allInt Then
                t = GetType(Long)
            ElseIf anyValue AndAlso allNum Then
                t = GetType(Double)
            End If
            dt.Columns.Add(names(i), t)
        Next
        For Each rw As Object() In rows
            Dim dr As DataRow = dt.NewRow()
            For i As Integer = 0 To names.Count - 1
                Dim v As Object = rw(i)
                If v Is Nothing OrElse IsDBNull(v) Then
                    dr(i) = DBNull.Value
                ElseIf dt.Columns(i).DataType Is GetType(String) Then
                    dr(i) = Convert.ToString(v, Globalization.CultureInfo.InvariantCulture)
                Else
                    dr(i) = v
                End If
            Next
            dt.Rows.Add(dr)
        Next
        Return dt
    End Function

    Public Function Execute(sql As String, ParamArray args() As Object) As Integer
        Using c As SqliteConnection = Open()
            Using cmd As SqliteCommand = c.CreateCommand()
                cmd.CommandText = sql
                AddParams(cmd, args)
                Return cmd.ExecuteNonQuery()
            End Using
        End Using
    End Function

    Public Function Scalar(sql As String, ParamArray args() As Object) As Object
        Using c As SqliteConnection = Open()
            Using cmd As SqliteCommand = c.CreateCommand()
                cmd.CommandText = sql
                AddParams(cmd, args)
                Return cmd.ExecuteScalar()
            End Using
        End Using
    End Function

    Public Function Num(sql As String, ParamArray args() As Object) As Double
        Dim o As Object = Scalar(sql, args)
        If o Is Nothing OrElse IsDBNull(o) Then Return 0
        Return Convert.ToDouble(o)
    End Function

    Public Function Hash(s As String) As String
        Using sha As SHA256 = SHA256.Create()
            Dim b As Byte() = sha.ComputeHash(Encoding.UTF8.GetBytes("KISUBI::" & s))
            Return BitConverter.ToString(b).Replace("-", "")
        End Using
    End Function

    Public Sub LogAction(action As String, detail As String)
        Try
            Execute("INSERT INTO ActivityLog(Stamp, UserName, Action, Detail) VALUES(@p0,@p1,@p2,@p3)",
                    DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), CurrentUser, action, detail)
        Catch
        End Try
    End Sub

    Public Sub InitDb()
        Dim schema As String =
            "CREATE TABLE IF NOT EXISTS Users(Id INTEGER PRIMARY KEY AUTOINCREMENT, Username TEXT UNIQUE NOT NULL, PasswordHash TEXT NOT NULL, FullName TEXT NOT NULL, Role TEXT NOT NULL, Status TEXT DEFAULT 'Active');" &
            "CREATE TABLE IF NOT EXISTS Students(Id INTEGER PRIMARY KEY AUTOINCREMENT, RegNo TEXT UNIQUE NOT NULL, FullName TEXT NOT NULL, Gender TEXT, DOB TEXT, Nationality TEXT, Faculty TEXT, Course TEXT, YearOfStudy INTEGER, Phone TEXT, Email TEXT, HomeAddress TEXT, NextOfKin TEXT, NextOfKinPhone TEXT, Status TEXT DEFAULT 'Active');" &
            "CREATE TABLE IF NOT EXISTS Hostels(Id INTEGER PRIMARY KEY AUTOINCREMENT, Name TEXT UNIQUE NOT NULL, Type TEXT, Location TEXT, WardenName TEXT, Contact TEXT, Description TEXT);" &
            "CREATE TABLE IF NOT EXISTS Rooms(Id INTEGER PRIMARY KEY AUTOINCREMENT, HostelId INTEGER NOT NULL, RoomNo TEXT NOT NULL, Floor INTEGER, RoomType TEXT, Capacity INTEGER NOT NULL, FeePerSemester REAL, Status TEXT DEFAULT 'Available', Notes TEXT, UNIQUE(HostelId, RoomNo));" &
            "CREATE TABLE IF NOT EXISTS Applications(Id INTEGER PRIMARY KEY AUTOINCREMENT, StudentId INTEGER NOT NULL, HostelId INTEGER, PreferredRoomType TEXT, Semester TEXT, AcademicYear TEXT, DateApplied TEXT, Status TEXT DEFAULT 'Pending', Remarks TEXT);" &
            "CREATE TABLE IF NOT EXISTS Allocations(Id INTEGER PRIMARY KEY AUTOINCREMENT, StudentId INTEGER NOT NULL, RoomId INTEGER NOT NULL, BedNo TEXT, Semester TEXT, AcademicYear TEXT, CheckInDate TEXT, CheckOutDate TEXT, Status TEXT DEFAULT 'Active', Remarks TEXT);" &
            "CREATE TABLE IF NOT EXISTS Payments(Id INTEGER PRIMARY KEY AUTOINCREMENT, ReceiptNo TEXT UNIQUE, StudentId INTEGER NOT NULL, Purpose TEXT, Amount REAL NOT NULL, PayDate TEXT, Method TEXT, Reference TEXT, Semester TEXT, AcademicYear TEXT, ReceivedBy TEXT);" &
            "CREATE TABLE IF NOT EXISTS Fines(Id INTEGER PRIMARY KEY AUTOINCREMENT, StudentId INTEGER NOT NULL, Reason TEXT, Amount REAL, DateIssued TEXT, Status TEXT DEFAULT 'Unpaid', Remarks TEXT);" &
            "CREATE TABLE IF NOT EXISTS Visitors(Id INTEGER PRIMARY KEY AUTOINCREMENT, VisitorName TEXT NOT NULL, IDNumber TEXT, Phone TEXT, StudentId INTEGER NOT NULL, Purpose TEXT, VisitDate TEXT, TimeIn TEXT, TimeOut TEXT);" &
            "CREATE TABLE IF NOT EXISTS Exeat(Id INTEGER PRIMARY KEY AUTOINCREMENT, StudentId INTEGER NOT NULL, Reason TEXT, Destination TEXT, DateOut TEXT, ExpectedReturn TEXT, ActualReturn TEXT, Status TEXT DEFAULT 'Pending', ApprovedBy TEXT);" &
            "CREATE TABLE IF NOT EXISTS Maintenance(Id INTEGER PRIMARY KEY AUTOINCREMENT, HostelId INTEGER NOT NULL, RoomId INTEGER, Category TEXT, Issue TEXT NOT NULL, Priority TEXT, ReportedBy TEXT, DateReported TEXT, AssignedTo TEXT, Status TEXT DEFAULT 'Open', DateResolved TEXT, Cost REAL);" &
            "CREATE TABLE IF NOT EXISTS Complaints(Id INTEGER PRIMARY KEY AUTOINCREMENT, StudentId INTEGER NOT NULL, Category TEXT, Subject TEXT NOT NULL, Details TEXT, DateLodged TEXT, Status TEXT DEFAULT 'Open', Resolution TEXT);" &
            "CREATE TABLE IF NOT EXISTS Inventory(Id INTEGER PRIMARY KEY AUTOINCREMENT, ItemName TEXT NOT NULL, Category TEXT, HostelId INTEGER NOT NULL, RoomId INTEGER, Quantity INTEGER, ItemCondition TEXT, DateAdded TEXT, Notes TEXT);" &
            "CREATE TABLE IF NOT EXISTS Staff(Id INTEGER PRIMARY KEY AUTOINCREMENT, FullName TEXT NOT NULL, Position TEXT, Phone TEXT, HostelId INTEGER, Shift TEXT, DateEmployed TEXT, Status TEXT DEFAULT 'Active');" &
            "CREATE TABLE IF NOT EXISTS Notices(Id INTEGER PRIMARY KEY AUTOINCREMENT, Title TEXT NOT NULL, Message TEXT, DatePosted TEXT, PostedBy TEXT, Audience TEXT, ExpiryDate TEXT);" &
            "CREATE TABLE IF NOT EXISTS ActivityLog(Id INTEGER PRIMARY KEY AUTOINCREMENT, Stamp TEXT, UserName TEXT, Action TEXT, Detail TEXT);"

        Using c As SqliteConnection = Open()
            Using cmd As SqliteCommand = c.CreateCommand()
                cmd.CommandText = schema
                cmd.ExecuteNonQuery()
            End Using
        End Using

        ' ---- default users (change these passwords after first login) ----
        If Num("SELECT COUNT(*) FROM Users") = 0 Then
            Execute("INSERT INTO Users(Username,PasswordHash,FullName,Role,Status) VALUES('admin',@p0,'System Administrator','Admin','Active')", Hash("admin123"))
            Execute("INSERT INTO Users(Username,PasswordHash,FullName,Role,Status) VALUES('warden',@p0,'Hostel Warden','Warden','Active')", Hash("warden123"))
            Execute("INSERT INTO Users(Username,PasswordHash,FullName,Role,Status) VALUES('bursar',@p0,'Accounts / Bursar','Bursar','Active')", Hash("bursar123"))
            Execute("INSERT INTO Users(Username,PasswordHash,FullName,Role,Status) VALUES('security',@p0,'Gate Security','Security','Active')", Hash("security123"))
        End If

        ' ---- sample hostels and rooms so the system can be tried straight away ----
        If Num("SELECT COUNT(*) FROM Hostels") = 0 Then
            Execute("INSERT INTO Hostels(Name,Type,Location,Description) VALUES('Hostel A','Male','Main Campus','Sample hostel - edit or delete')")
            Execute("INSERT INTO Hostels(Name,Type,Location,Description) VALUES('Hostel B','Female','Main Campus','Sample hostel - edit or delete')")
            For Each hn As String In New String() {"Hostel A", "Hostel B"}
                Dim hid As Long = Convert.ToInt64(Scalar("SELECT Id FROM Hostels WHERE Name=@p0", hn))
                For fl As Integer = 1 To 2
                    For n As Integer = 1 To 6
                        Execute("INSERT INTO Rooms(HostelId,RoomNo,Floor,RoomType,Capacity,FeePerSemester,Status) VALUES(@p0,@p1,@p2,'Double',2,450000,'Available')",
                                hid, (fl * 100 + n).ToString(), fl)
                    Next
                Next
            Next
        End If
    End Sub
End Module
