Imports System.Data
Imports System.Drawing
Imports System.Globalization
Imports System.Linq
Imports System.Windows.Forms
Imports Microsoft.Data.Sqlite

Public Enum FieldKind
    Text
    Multiline
    Number
    Money
    Dt
    DateOpt
    Choice
    Lookup
    Password
End Enum

Public Class FieldDef
    Public Column As String
    Public Caption As String
    Public Kind As FieldKind = FieldKind.Text
    Public Options As String() = New String() {}
    Public LookupSql As String = ""
    Public Required As Boolean = False
    Public DefaultValue As String = ""

    Public Function Def(v As String) As FieldDef
        DefaultValue = v
        Return Me
    End Function
End Class
