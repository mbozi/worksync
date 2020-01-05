Imports umbraco.Web.Mvc
Imports System.Web.Mvc
Imports umbraco.Core.Models
Imports System.Runtime.Caching
Imports umbraco.Web

Public Class DatabaseController
    Inherits SurfaceController

    Private Const PARTIAL_VIEW_FOLDER = "~/Views/Partials/Politics/"

    Public Function RenderGridItems() As ActionResult
        Return PartialView(PARTIAL_VIEW_FOLDER & "_GridItems.vbhtml")
    End Function

    Public Function OpinionPolls() As PartialViewResult
        Dim model As New SelectList(DLayer.GetPollingCompaniesModel.OrderBy(Function(x) x.ID <> 0).ThenBy(Function(x) x.PollerName), "ID", "PollerName")
        Return PartialView(PARTIAL_VIEW_FOLDER & "_PollPage.cshtml", model)
    End Function

    Public Function RenderPoll() As ActionResult
        Return PartialView(PARTIAL_VIEW_FOLDER & "_viewPoll.vbhtml")
    End Function

    Public Function RenderPollsTable(Optional id As String = "0") As PartialViewResult
        Dim data As IEnumerable(Of Poll) = DLayer.GetPollModel().Where(Function(x) x.PollerID = CInt(id) Or id = "0")
        Return PartialView(PARTIAL_VIEW_FOLDER & "_PollTable.cshtml", data)
    End Function

End Class
