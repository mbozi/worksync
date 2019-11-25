Imports System.Collections.Generic
Imports System.Linq
Public Class Navigation

    Public Property Text As String
    Public Property Url As String
    Public Property NewWindow As Boolean
    Public ReadOnly Property Target As String
        Get
            Return If(NewWindow, "_blank", Nothing)
        End Get
    End Property
    Public Property Title As String

    Public Sub New()
    End Sub

    Public Sub New(ByVal sUrl As String, ByVal Optional sText As String = Nothing, ByVal Optional bNewWindow As Boolean = False, ByVal Optional sTitle As String = Nothing)
        Text = sText
        Url = sUrl
        NewWindow = bNewWindow
        Title = sTitle
    End Sub

End Class


Public Class NavigationListItem
    Public Property Text As String
    Public Property Link As Navigation
    Public Property Items As List(Of NavigationListItem)

    Public ReadOnly Property HasChildren As Boolean
        Get
            Return Items IsNot Nothing AndAlso Items.Any() AndAlso Items.Count > 0
        End Get
    End Property

    Public Sub New()
    End Sub

    Public Sub New(ByVal nlink As Navigation)
        Link = nlink
    End Sub

    Public Sub New(ByVal stext As String)
        Text = stext
    End Sub
End Class

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
