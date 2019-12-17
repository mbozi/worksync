@Imports worksync
@ModelType List(Of ArticleImageGallery)



<div class="row">
    <div class="col-sm-10 col-md-8 col-lg-6 col-xl-4 offset-sm-1 offset-md-2 offset-lg-3 offset-xl-4">
        <ul class="article-list">
            @RenderArticleItemList(Model)
        </ul>
    </div>
</div>


@Helper RenderArticleItemList(items As List(Of ArticleImageGallery))

    @For Each item As ArticleImageGallery In Model.OrderByDescending(Function(x) x.ItemDate)
        Dim T0 As String = String.Empty
        Dim T1 As String = String.Empty
        T0 = item.LinkURL
        T1 = item.Name
        Dim Tag As String = String.Format("<li><a href=""{0}""><i class=""fas fa-feather""></i> {1}</a></li>", T0, T1)
        @Html.Raw(Tag)
        @*@<tr id="@item.LinkURL"><td>@item.Name</td><td> @Html.Raw(item.Introduction)</td><td>@item.ItemDate</td><td>@item.ImageFolder</td><td>@item.LinkURL</td><td>@item.ImageURL</td></tr>*@
    Next
End Helper










