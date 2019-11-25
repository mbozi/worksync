Imports umbraco.Web.Mvc
Imports System.Web.Mvc
Imports umbraco.Core.Models
Imports System.Runtime.Caching
Imports umbraco.Web

Public Class SiteLayoutController
    Inherits SurfaceController

    Private Const PARTIAL_VIEW_FOLDER = "~/Views/Partials/SiteLayout/"

    Public Function RenderHeader() As ActionResult
        'Dim nav As New NavigationParameter With {.PageName = CurrentPage.Name, .PageList = GetNavigationModelFromDatabase()}

        Dim nav As New NavigationParameter With {.PageName = CurrentPage.Name, .PageList = GetObjectFromCache(Of List(Of NavigationListItem))("mainNav", 0, AddressOf GetNavigationModelFromDatabase)}
        Return PartialView(PARTIAL_VIEW_FOLDER & "_Header.vbhtml", nav)
    End Function

    Public Function RenderIntro() As ActionResult
        Return PartialView(PARTIAL_VIEW_FOLDER & "_Intro.vbhtml")
    End Function

    Public Function RenderFooter() As ActionResult
        Return PartialView(PARTIAL_VIEW_FOLDER & "_Footer.vbhtml")
    End Function

    Public Function RenderTitleControls() As ActionResult
        Return PartialView(PARTIAL_VIEW_FOLDER & "_TitleControls.vbhtml")
    End Function


    Private Function GetNavigationModelFromDatabase() As List(Of NavigationListItem)
        Dim homePage As IPublishedContent = CurrentPage.AncestorOrSelf(1).DescendantsOrSelf().Where(Function(x) x.DocumentTypeAlias = "home").FirstOrDefault()
        Dim nav As List(Of NavigationListItem) = New List(Of NavigationListItem) From {
            New NavigationListItem With {.Link = New Navigation With {.Url = homePage.Url, .Text = homePage.Name}}
        }
        Dim childlist As List(Of NavigationListItem) = GetChildNavigationList(homePage)
        If Not IsNothing(childlist) Then nav.AddRange(childlist)
        Return nav
    End Function

    Private Shared Function GetChildNavigationList(ByVal page As IPublishedContent) As List(Of NavigationListItem)
        Dim listItems As List(Of NavigationListItem) = Nothing
        Dim childPages = page.Children.Where(Function(x) Not (x.HasValue("excludeFromTopNavigation")) Or (x.HasValue("excludeFromTopNavigation") AndAlso CType(x.GetPropertyValue("excludeFromTopNavigation"), Boolean) = False))

        If childPages IsNot Nothing AndAlso childPages.Any() Then
            listItems = New List(Of NavigationListItem)()

            For Each childPage In childPages
                Dim listItem As NavigationListItem = New NavigationListItem With {.Link = New Navigation With {.Url = childPage.Url, .Text = childPage.Name}}
                'listItem.Items = GetChildNavigationList(childPage)
                listItems.Add(listItem)
            Next
        End If

        Return listItems
    End Function

    Private Shared Function GetObjectFromCache(Of T)(ByVal cacheItemName As String, ByVal cacheTimeInMinutes As Integer, ByVal objectSettingFunction As Func(Of T)) As T
        Dim cache As ObjectCache = MemoryCache.[Default]
        Dim cachedObject = CType(cache(cacheItemName), T)

        If cachedObject Is Nothing Then
            Dim policy As CacheItemPolicy = New CacheItemPolicy With {.AbsoluteExpiration = DateTimeOffset.Now.AddMinutes(cacheTimeInMinutes)}
            cachedObject = objectSettingFunction()
            cache.[Set](cacheItemName, cachedObject, policy)
        End If

        Return cachedObject
    End Function
End Class
