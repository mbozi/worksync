@Imports worksync
@ModelType List(Of ArticleImageGallery)
<div class="container">
        <div class="card shadow">
            <div class="card-body">
                <div class="row">
                    <div class="col-md-6 text-nowrap">
                        <div id="dataTable_length" class="dataTables_length" aria-controls="dataTable"><label>Show&nbsp;<select class="form-control form-control-sm custom-select custom-select-sm"><option value="10" selected="">10</option><option value="25">25</option><option value="50">50</option><option value="100">100</option></select>&nbsp;</label></div>
                    </div>
                    <div class="col-md-6">
                        <div class="text-md-right dataTables_filter" id="dataTable_filter"><label><input type="search" class="form-control form-control-sm" aria-controls="dataTable" placeholder="Search"></label></div>
                    </div>
                </div>
                <div class="table-responsive table mt-2" id="dataTable" role="grid" aria-describedby="dataTable_info">

                    @RenderBlogPreview(Model)

                </div>
                <div class="row">
                    <div class="col-md-6 align-self-center">
                        <p id="dataTable_info" class="dataTables_info" role="status" aria-live="polite">Showing 1 to 10 of 27</p>
                    </div>
                    <div class="col-md-6">
                        <nav class="d-lg-flex justify-content-lg-end dataTables_paginate paging_simple_numbers">
                            <ul class="pagination">
                                <li class="page-item disabled"><a class="page-link" href="#" aria-label="Previous"><span aria-hidden="true">«</span></a></li>
                                <li class="page-item active"><a class="page-link" href="#">1</a></li>
                                <li class="page-item"><a class="page-link" href="#">2</a></li>
                                <li class="page-item"><a class="page-link" href="#">3</a></li>
                                <li class="page-item"><a class="page-link" href="#" aria-label="Next"><span aria-hidden="true">»</span></a></li>
                            </ul>
                        </nav>
                    </div>
                </div>
            </div>
        </div>
    </div>



@Helper RenderBlogPreview(items As List(Of ArticleImageGallery))
    @<Table Class="table dataTable my-0" id="dataTable">
        <thead>
            <tr>
                <th> Name</th>
                <th> Position</th>
                <th> Office</th>
                <th> Age</th>
                <th> Start Date</th>
                <th> Salary</th>
            </tr>
        </thead>
        <tbody>
            @For Each item As ArticleImageGallery In Model.OrderByDescending(Function(x) x.ItemDate)
                @<tr><td>@item.Name</td><td> @item.Introduction</td><td>@item.ItemDate</td><td>@item.ImageFolder</td><td>@item.LinkURL</td><td>@item.ImageURL</td></tr>
            Next

        <tfoot>
            @*<tr>
                <td><strong>Name</strong></td>
                <td><strong>Position</strong></td>
                <td><strong>Office</strong></td>
                <td><strong>Age</strong></td>
                <td><strong>Start date</strong></td>
                <td><strong>Salary</strong></td>
            </tr>*@
        </tfoot>
    </Table>
End Helper




@*<div class="container">
        <div class="row">
            @For Each item As ArticleImageGallery In Model.OrderByDescending(Function(x) x.ItemDate)
                @RenderBlogPreview(item)
            Next
        </div>
    </div>*@

@*@Helper RenderBlogPreview(item As ArticleImageGallery)
    <div class="col-md-4 text-center">
        <div class="blog-inner">
            <a href="@item.LinkURL" target=""><img class="img-responsive" src="" alt="@item.Name"></a>
            <div class="desc">
                <h3><a href="@item.LinkURL" target="">@item.Name</a></h3>
                <a>@item.ItemDate.ToString("dd MMM yyyy")</a>
                <p>@item.Introduction</p>
                @*<p><a href="@item.LinkURL" class="btn btn-primary btn-outline with-arrow">Read More<i class="icon-arrow-right"></i></a></p>
            </div>
        </div>
    </div>*@
@*End Helper*@








