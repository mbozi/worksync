@inherits UmbracoTemplatePage
@*<div id="fh5co-intro-section">
    <div class="container">
        <div class="row">
            <div class="col-md-8 col-md-offset-2 text-center">
                <h2>@Umbraco.AssignedContentItem.GetPropertyValue("title")</h2>
                <p><span>@Umbraco.AssignedContentItem.GetPropertyValue("subTitle")</span> </p>
            </div>
        </div>
    </div>
</div>*@

<div class="pagetitle">
    <div class="pHeader">@Umbraco.AssignedContentItem.GetPropertyValue("title")</div>
    <div class="pDesc">@Umbraco.AssignedContentItem.GetPropertyValue("subTitle") </div>
</div>
