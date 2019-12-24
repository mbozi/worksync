@Imports worksync
@ModelType List(Of ArticleImageGallery)

<div class="row">
    <div class="col-6 offset-3">
        <table class="table table-condensed table-striped">
            <colgroup>
                <col style="width:50px;">
                <col style="width:auto;">
                <col style="width:100px;">
            </colgroup>
            @RenderArticleItemList(Model)
        </table>
    </div>
</div>

@section ScriptsEnd
    <script src="/assets/js/table.js"></script>
End section

@Helper RenderArticleItemList(items As List(Of ArticleImageGallery))

    @For Each item As ArticleImageGallery In Model.OrderByDescending(Function(x) x.ItemDate)
        @<tr class="clickable-row" data-href="@item.LinkURL" style="cursor:pointer">
            <td>
                <i class="fas fa-feather d-inline-block" style="margin: 0px;margin-top: 10px;"></i>
            </td>
            <td>
                <div Class="contentcol2" style="width: 400px;">
                    <h5>@item.Name</h5>
                    <h6>@Html.Raw(item.Introduction)</h6>
                </div>
            </td>
            <td>
                <p Class="text-right d-table-cell" style="font-size: 11px;line-height: 12px;margin: 5px 10px 0px 0px;">@item.ItemDate.ToString("dd MMM yyyy")</p>
            </td>
        </tr>
    Next
End Helper













