Imports System.Data

''' <summary>Lookup queries and business rules used by the forms.</summary>
Public Module Rules
    Public ReadOnly StudentLk As String =
        "SELECT Id, RegNo || ' - ' || FullName AS Text FROM Students ORDER BY FullName"
    Public ReadOnly HostelLk As String =
        "SELECT Id, Name AS Text FROM Hostels ORDER BY Name"
    Public ReadOnly HostelAnyLk As String =
        "SELECT 0 AS Id, '(Any hostel)' AS Text UNION ALL SELECT * FROM (SELECT Id, Name AS Text FROM Hostels ORDER BY Name)"
    Public ReadOnly HostelNoneLk As String =
        "SELECT 0 AS Id, '(None)' AS Text UNION ALL SELECT * FROM (SELECT Id, Name AS Text FROM Hostels ORDER BY Name)"
    Public ReadOnly RoomLk As String =
        "SELECT r.Id, h.Name || ' - Room ' || r.RoomNo || ' (' || r.RoomType || ', ' || r.Capacity || ' beds)' AS Text " &
        "FROM Rooms r JOIN Hostels h ON h.Id = r.HostelId ORDER BY h.Name, r.RoomNo"
    Public ReadOnly RoomNoneLk As String =
        "SELECT 0 AS Id, '(None)' AS Text UNION ALL SELECT * FROM (" & RoomLk & ")"

    Public Function AllocationCheck(d As Dictionary(Of String, Object), id As Long) As String
        Dim status As String = CStr(d("Status"))
        Dim cin As String = CStr(d("CheckInDate"))
        Dim cout As String = CStr(d("CheckOutDate"))
        If cout <> "" AndAlso String.Compare(cout, cin, StringComparison.Ordinal) < 0 Then
            Return "Check-out date cannot be before the check-in date."
        End If
        If status = "Checked Out" AndAlso cout = "" Then d("CheckOutDate") = Theme.Iso(Date.Today)
        If status <> "Active" Then Return ""

        Dim roomId As Long = Convert.ToInt64(d("RoomId"))
        Dim studentId As Long = Convert.ToInt64(d("StudentId"))

        If Convert.ToString(Db.Scalar("SELECT Status FROM Rooms WHERE Id=@p0", roomId)) = "Under Maintenance" Then
            Return "This room is under maintenance and cannot be allocated."
        End If
        Dim cap As Double = Db.Num("SELECT Capacity FROM Rooms WHERE Id=@p0", roomId)
        Dim occ As Double = Db.Num("SELECT COUNT(*) FROM Allocations WHERE RoomId=@p0 AND Status='Active' AND Id<>@p1", roomId, id)
        If occ >= cap Then Return "This room is already full (" & cap & " bed(s))."

        If Db.Num("SELECT COUNT(*) FROM Allocations WHERE StudentId=@p0 AND Status='Active' AND Id<>@p1", studentId, id) > 0 Then
            Return "This student already has an active room. Check them out first."
        End If

        Dim chk As DataTable = Db.Query("SELECT s.Gender AS Gender, h.Type AS HType FROM Students s, Hostels h WHERE s.Id=@p0 AND h.Id=(SELECT HostelId FROM Rooms WHERE Id=@p1)", studentId, roomId)
        If chk.Rows.Count = 1 Then
            Dim ht As String = Convert.ToString(chk.Rows(0)("HType"))
            Dim g As String = Convert.ToString(chk.Rows(0)("Gender"))
            If ht <> "Mixed" AndAlso g <> "" AndAlso ht <> g Then
                Return "This is a " & ht & " hostel but the student is " & g & "."
            End If
        End If
        Return ""
    End Function

    Public Function PaymentCheck(d As Dictionary(Of String, Object), id As Long) As String
        If Convert.ToDouble(d("Amount")) <= 0 Then Return "Amount must be greater than zero."
        If CStr(d("ReceiptNo")) = "" Then d("ReceiptNo") = "RCT-" & DateTime.Now.ToString("yyMMdd-HHmmss")
        Return ""
    End Function

    Public Function FineCheck(d As Dictionary(Of String, Object), id As Long) As String
        If Convert.ToDouble(d("Amount")) <= 0 Then Return "Amount must be greater than zero."
        Return ""
    End Function

    Public Function ExeatCheck(d As Dictionary(Of String, Object), id As Long) As String
        If String.Compare(CStr(d("ExpectedReturn")), CStr(d("DateOut")), StringComparison.Ordinal) < 0 Then
            Return "Expected return cannot be before the leaving date."
        End If
        If CStr(d("ActualReturn")) <> "" AndAlso (CStr(d("Status")) = "Pending" OrElse CStr(d("Status")) = "Approved") Then
            d("Status") = "Returned"
        End If
        Return ""
    End Function

    Public Function MaintenanceCheck(d As Dictionary(Of String, Object), id As Long) As String
        If CStr(d("Status")) = "Resolved" AndAlso CStr(d("DateResolved")) = "" Then d("DateResolved") = Theme.Iso(Date.Today)
        Return ""
    End Function

    Public Function UserCheck(d As Dictionary(Of String, Object), id As Long) As String
        If CStr(d("Username")).Contains(" ") Then Return "Username cannot contain spaces."
        Dim pw As String = CStr(d("PasswordHash"))
        If pw <> "" AndAlso pw.Length < 6 Then Return "Password must be at least 6 characters."
        Return ""
    End Function
End Module
