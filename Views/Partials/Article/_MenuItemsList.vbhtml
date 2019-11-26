@Imports worksync
@ModelType List(Of ArticlePreview)
<div class="container">
    <div class="row">
        @For Each item As ArticlePreview In Model.OrderByDescending(Function(x) x.ItemDate)
            @RenderBlogPreview(item)
        Next
    </div>
</div>

@Helper RenderBlogPreview(item As ArticlePreview)
    @<div class="col-md-4 text-center">
        <div class="blog-inner">
            <a href="@item.LinkURL" target=""><img class="img-responsive" src="" alt="@item.Name"></a>
            <div class="desc">
                <h3><a href="@item.LinkURL" target="">@item.Name</a></h3>
                <a>@item.ItemDate.ToString("dd MMM yyyy")</a>
                <p>@item.Introduction</p>
                @*<p><a href="@item.LinkURL" class="btn btn-primary btn-outline with-arrow">Read More<i class="icon-arrow-right"></i></a></p>*@
            </div>
        </div>
    </div>
End Helper








