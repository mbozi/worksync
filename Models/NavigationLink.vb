Public Class NavigationLink

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
