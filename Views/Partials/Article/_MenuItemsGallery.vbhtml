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
                    <h3>
                        <a href="@item.LinkURL">@item.Name</a>
                    </h3>
                    <span>
                        <a>@item.ItemDate.ToString("dd MMM yyyy")</a>
                        @Html.Raw(item.Introduction)
                    </span>
                </div>
            </div>
        </div>
    Next
End Helper





    





