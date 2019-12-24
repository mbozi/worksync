Imports System.ComponentModel.DataAnnotations
Imports System.Web.Mvc
Public Class ArticleImageGallery
    Public Property Name As String
    Public Property Introduction As String
    Public Property ImageURL As String
    Public Property LinkURL As String
    Public Property ItemDate As Date
    Public Property ImageFolder As String

    Public Sub New()
    End Sub

    Public Sub New(
                  ByVal sName As String,
                  ByVal Optional sIntroduction As String = Nothing,
                  ByVal Optional sImageURL As String = Nothing,
                  ByVal Optional sLinkURL As String = Nothing,
                  ByVal Optional dDate As Date = Nothing,
                  ByVal Optional sImageFolder As String = Nothing
                  )
        Name = sName
        Introduction = sIntroduction
        ImageURL = sImageURL
        LinkURL = sLinkURL
        ItemDate = dDate
        ImageFolder = sImageFolder
    End Sub
End Class

Public Class ArticleForumPost
    Public Property Name As String
    Public Property Introduction As String
    Public Property ImageURL As String
    Public Property LinkURL As String
    Public Property ItemDate As Date
    Public Property ImageFolder As String

    Public Sub New()
    End Sub

    Public Sub New(
                  ByVal sName As String,
                  ByVal Optional sIntroduction As String = Nothing,
                  ByVal Optional sImageURL As String = Nothing,
                  ByVal Optional sLinkURL As String = Nothing,
                  ByVal Optional dDate As Date = Nothing,
                  ByVal Optional sImageFolder As String = Nothing
                  )
        Name = sName
        Introduction = sIntroduction
        ImageURL = sImageURL
        LinkURL = sLinkURL
        ItemDate = dDate
        ImageFolder = sImageFolder
    End Sub
End Class
