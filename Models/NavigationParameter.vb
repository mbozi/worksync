Imports System.Collections.Generic
Imports System.Linq
Public Class NavigationParameter

    Public Property PageName As String
    Public Property PageList As List(Of NavigationListItem)

    Public Sub New()
    End Sub

    Public Sub New(ByVal sName As String, ByVal nlist As List(Of NavigationListItem))
        PageName = sName
        PageList = nlist
    End Sub

End Class
