Imports System.Collections.Generic
Imports System.Linq
Public Class NavigationListItem
    Public Property Text As String
    Public Property Link As NavigationLink
    Public Property Items As List(Of NavigationListItem)

    Public ReadOnly Property HasChildren As Boolean
        Get
            Return Items IsNot Nothing AndAlso Items.Any() AndAlso Items.Count > 0
        End Get
    End Property

    Public Sub New()
    End Sub

    Public Sub New(ByVal nlink As NavigationLink)
        Link = nlink
    End Sub

    Public Sub New(ByVal stext As String)
        Text = stext
    End Sub
End Class
