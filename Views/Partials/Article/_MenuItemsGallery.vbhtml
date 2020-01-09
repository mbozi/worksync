@Imports worksync
@ModelType List(Of ArticleImageGallery)

    <div class="container">
        <div class="row">
            @RenderBlogPreview(Model)
        </div>
    </div>

@Helper RenderBlogPreview(items As List(Of ArticleImageGallery))
    For Each item As ArticleImageGallery In Model.OrderByDescending(Function(x) x.ItemDate)
        @<div class="col-md-6 text-center">
            <div class="work-inner">
                <a class="workgrid" href="@item.LinkURL" style="background-image: url('@item.ImageURL');"></a>
                <div class="desc">
                    <div class="menu-item-title">@item.Name</div>
                    <div class="menu-item-date">@item.ItemDate.ToString("dd MMM yyyy")</div>
                    <div class="menu-item-desc">@Html.Raw(item.Introduction)</div>
                </div>
            </div>
        </div>
    Next
End Helper





    





