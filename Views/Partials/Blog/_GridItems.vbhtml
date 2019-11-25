@imports worksync
@ModelType List(Of Photo)

@RenderChildItems()


@Helper RenderChildItems()                                  
    For Each item As Photo In Model
        @<div Class="grid-item item animate-box" data-animate-effect="fadeIn">
            <a href="@item.PhotoURL" Class="image-popup" title="@item.PhotoTitle<">
                <div class="img-wrap">
                    <img src="@item.PhotoURL" alt="" class="img-responsive">
                </div>
                <div Class="text-wrap">
                    <div Class="text-inner">
                        <div>
                            <h2>@item.PhotoTitle</h2>
                        </div>
                    </div>
                </div>
            </a>
        </div>                                              
    Next

End Helper
