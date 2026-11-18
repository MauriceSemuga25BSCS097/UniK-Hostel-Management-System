Imports System.Windows.Forms

''' <summary>Maps a menu key to its designer form.</summary>
Public Module ModuleFactory
    Public Function Build(key As String) As Form
        Select Case key
            Case "students" : Return New StudentsForm()
            Case "applications" : Return New ApplicationsForm()
            Case "hostels" : Return New HostelsForm()
            Case "rooms" : Return New RoomsForm()
            Case "allocations" : Return New AllocationsForm()
            Case "payments" : Return New PaymentsForm()
            Case "fines" : Return New FinesForm()
            Case "visitors" : Return New VisitorsForm()
            Case "exeat" : Return New ExeatForm()
            Case "maintenance" : Return New MaintenanceForm()
            Case "complaints" : Return New ComplaintsForm()
            Case "inventory" : Return New InventoryForm()
            Case "staff" : Return New StaffForm()
            Case "notices" : Return New NoticesForm()
            Case "reports" : Return New ReportsForm()
            Case "users" : Return New UsersForm()
            Case "log" : Return New ActivityLogForm()
            Case Else : Return New DashboardForm()
        End Select
    End Function
End Module
