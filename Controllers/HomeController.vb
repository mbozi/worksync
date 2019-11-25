Imports umbraco.Web.Mvc
Imports System.Web.Mvc

Public Class HomeController
    Inherits SurfaceController

    Private Const PARTIAL_VIEW_FOLDER = "~/Views/Partials/Home/"

    Public Function RenderFeatured() As ActionResult
        Return PartialView(PARTIAL_VIEW_FOLDER & "_Featured.vbhtml")
    End Function

    Public Function RenderServices() As ActionResult
        Return PartialView(PARTIAL_VIEW_FOLDER & "_Services.vbhtml")
    End Function

    Public Function RenderBlog() As ActionResult
        Return PartialView(PARTIAL_VIEW_FOLDER & "_Blog.vbhtml")
    End Function

    Public Function RenderClients() As ActionResult
        Return PartialView(PARTIAL_VIEW_FOLDER & "_Clients.vbhtml")
    End Function


End Class
