
@ModelType worksync.NavigationParameter



<header id="fh5co-header" role="banner">
    <div Class="container">
        <div Class="header-inner">
            <h1> <i Class="sl-icon-energy"></i><a href="\">WORKSYNC</a></h1>
            <nav role="navigation">
                <ul>
                    @RenderChildItems(Model.PageList)
                </ul>
            </nav>
        </div>
    </div>
</header>

@Helper RenderChildItems(listitems As IEnumerable(Of worksync.NavigationListItem))
    If listitems IsNot Nothing Then
        For Each item As worksync.NavigationListItem In listitems
            Dim T0 As String = String.Empty
            Dim T1 As String = String.Empty
            Dim T2 As String = String.Empty
            Dim T3 As String = String.Empty
            If item.Link IsNot Nothing Then
                T0 = item.Link.Url
                T2 = item.Link.Target
                T3 = item.Link.Text
                If Model.PageName.ToLower = item.Link.Url.Replace("/", "") Or (Model.PageName.ToLower = "home" AndAlso item.Link.Url = "/") Then
                    T1 = "active"
                    If item.HasChildren Then T1 &= "fh5co-Sub-ddown"
                End If
                Dim Tag As String = String.Format("<li><a href=""{0}"" Class=""{1}"" Target=""{2}"">{3}</a></li>", T0, T1, T2, T3)
                @Html.Raw(Tag) End If
        Next
        @Html.Raw(String.Format("<li><a href=""{0}"" Class=""{1}"" Target=""{2}"">{3}</a></li>", "/Umbraco/", "", "", "Login"))
    End If

End Helper
