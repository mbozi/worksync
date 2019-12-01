@Imports worksync
@ModelType List(Of ArticleImageGallery)

<div class="article-list" style="margin-bottom: 9em;">
    <div class="container">
        <div class="row articles">
            @RenderBlogPreview(Model)
        </div>
    </div>
</div>




@Helper RenderBlogPreview(items As List(Of ArticleImageGallery))
    For Each item As ArticleImageGallery In Model.OrderByDescending(Function(x) x.ItemDate)
        @<div Class="col-sm-6 col-md-4 item">
            <a href="@item.LinkURL" target="_blank"><img class="img-fluid" src="@item.ImageURL"></a>
            <h3 Class="name">@item.Name</h3>
            <a>@item.ItemDate.ToString("dd MMM yyyy")</a>
            <p Class="description">@item.Introduction</p>
        </div>
    Next
End Helper









