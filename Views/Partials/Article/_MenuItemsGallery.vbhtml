@Imports worksync
@ModelType List(Of ArticleImageGallery)

<div class="article-menu-container">
    @RenderBlogPreview(Model)
</div>

@Helper RenderBlogPreview(items As List(Of ArticleImageGallery))
    For Each item As ArticleImageGallery In Model.OrderByDescending(Function(x) x.ItemDate)
        @<div Class="article-menu-item" data-href="@item.LinkURL">
            <img src="@item.ImageURL" >
            <div class="desc">
                <div class="menu-item-title">@item.Name</div>
                <div class="menu-item-date">@item.ItemDate.ToString("dd MMM yyyy")</div>
                <div class="menu-item-desc">@Html.Raw(item.Introduction)</div>
            </div>
         </div>
    Next
End Helper











