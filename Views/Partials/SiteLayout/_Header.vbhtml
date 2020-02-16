
@ModelType worksync.NavigationParameter
<header>
    <nav class="nbar fixed-top shadow">
        <div class="nbar-container">
            <a class="nbar-brand" href="http://worksync.net">worksync.net</a>
            <button data-toggle="collapse" class="nbar-toggler" data-target="#navcol-1">
                <span class="sr-only">Toggle navigation</span>
                <i class="fas fa-bars"></i>
            </button>
            <div class="nbar-collapse collapse show" id="navcol-1">
                <ul class="nbar-items">
                    @RenderChildItems(Model.PageList)
                </ul>
            </div>
        </div>
    </nav>
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
                If Not IsNothing(item.Link.Target) Then T2 = String.Format("Target = ""{0}""", item.Link.Target)
                T3 = item.Link.Text
                If Model.PageName.ToLower = item.Link.Url.Replace("/", "") Or (Model.PageName.ToLower = "home" AndAlso item.Link.Url = "/") Then
                    T1 = " active"
                    'If item.HasChildren Then T1 &= "fh5co-Sub-ddown"
                End If
                'Dim Tag1 As String = String.Format("<li><a href=""{0}"" Class=""{1}"" Target=""{2}"">{3}</a></li>", T0, T1, T2, T3)
                Dim Tag As String = vbTab & String.Format("<li class=""nbar-item"" role=""presentation""><a class=""nbar-link{1}"" href=""{0}"" {2}>{3}</a></li>", T0, T1, T2, T3) & vbCrLf
                @Html.Raw(Tag) End If
        Next
        @Html.Raw(String.Format("<li class=""nbar-item"" role=""presentation""><a class=""nbar-link{1}"" href=""{0}"" Target=""{2}"">{3}</a></li>", "/Umbraco/", "", "_blank", "Login"))
    End If

End Helper
