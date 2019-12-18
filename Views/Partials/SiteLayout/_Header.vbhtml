
@ModelType worksync.NavigationParameter


    <header>
        <nav class="navbar navbar-light navbar-expand-md fixed-top border-info shadow">
            <div class="container-fluid">
                <a class="navbar-brand" href="#" style="font-size: 14pt;">worksync.net</a><button data-toggle="collapse" class="navbar-toggler" data-target="#navcol-1"><span class="sr-only">Toggle navigation</span><i class="fas fa-bars"></i></button>
                <div class="collapse navbar-collapse" id="navcol-1">
                    <ul class="nav navbar-nav ml-auto">
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
                T2 = item.Link.Target
                T3 = item.Link.Text
                If Model.PageName.ToLower = item.Link.Url.Replace("/", "") Or (Model.PageName.ToLower = "home" AndAlso item.Link.Url = "/") Then
                    T1 = " active"
                    'If item.HasChildren Then T1 &= "fh5co-Sub-ddown"
                End If
                'Dim Tag1 As String = String.Format("<li><a href=""{0}"" Class=""{1}"" Target=""{2}"">{3}</a></li>", T0, T1, T2, T3)
                Dim Tag As String = String.Format("<li class=""nav-item"" role=""presentation""><a class=""nav-link{1}"" href=""{0}"" Target=""{2}"">{3}</a></li>", T0, T1, T2, T3)
                @Html.Raw(Tag) End If
        Next
        @Html.Raw(String.Format("<li class=""nav-item"" role=""presentation""><a class=""nav-link{1}"" href=""{0}"" Target=""{2}"">{3}</a></li>", "/Umbraco/", "", "_blank", "Login"))
    End If

End Helper
