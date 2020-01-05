@imports worksync
@ModelType List(Of Photo)

<div class="portfolio">
    @RenderChildItems()
</div>



@Helper RenderChildItems()
        For Each item As Photo In Model
            @<div Class="portfolio_item">
                <img src="@item.PhotoURL" alt="" Class="img-responsive">
            </div>
        Next

    End Helper
