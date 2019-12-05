Imports umbraco.Web.Mvc
Imports System.Web.Mvc
Imports umbraco.Core.Models
Imports System.Runtime.Caching
Imports umbraco.Web

Public Class ArticleController
    Inherits SurfaceController

    Private Const PARTIAL_VIEW_FOLDER = "~/Views/Partials/Article/"

    Public Function RenderMenuPageGallery() As ActionResult
        Dim model As New List(Of ArticleImageGallery)
        Dim blogpage As IPublishedContent = CurrentPage.AncestorOrSelf(1).DescendantsOrSelf().Where(Function(x) x.DocumentTypeAlias = "menuPage" AndAlso x.Name = CurrentPage.Name).FirstOrDefault
        For Each page As IPublishedContent In blogpage.Children
            model.Add(New ArticleImageGallery With {
                      .ImageURL = page.GetPropertyValue("articleImage").URL,
                      .Introduction = page.GetPropertyValue("subTitle").ToString,
                      .LinkURL = "\Gallery?FolderName=" & page.GetPropertyValue("imageFolder").ToString,
                      .Name = page.GetPropertyValue("title").ToString,
                      .ItemDate = page.GetPropertyValue("articleDate")})
        Next
        Return PartialView(PARTIAL_VIEW_FOLDER & "_MenuItemsGallery.vbhtml", model)
    End Function

    Public Function RenderMenuPageList() As ActionResult
        Dim model As New List(Of ArticleImageGallery)
        Dim blogpage As IPublishedContent = CurrentPage.AncestorOrSelf(1).DescendantsOrSelf().Where(Function(x) x.DocumentTypeAlias = "menuPage" AndAlso x.Name = CurrentPage.Name).FirstOrDefault
        For Each page As IPublishedContent In blogpage.Children
            model.Add(New ArticleImageGallery With {
                      .ImageURL = "",
                      .Introduction = page.GetPropertyValue("subTitle").ToString,
                      .LinkURL = page.UrlName,
                      .Name = page.GetPropertyValue("title").ToString,
                      .ItemDate = page.GetPropertyValue("articleDate")})
        Next
        Return PartialView(PARTIAL_VIEW_FOLDER & "_MenuItemsList.vbhtml", model)
    End Function

    Public Function RenderGallery(FolderName As String) As ActionResult
        Dim model As List(Of Photo) = DLayer.GetPhotoListFromDirectory("~/Images/Photography/" & FolderName)
        Return PartialView(PARTIAL_VIEW_FOLDER & "_GridItems.vbhtml", model)
    End Function

End Class
