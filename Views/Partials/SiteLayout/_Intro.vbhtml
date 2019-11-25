@inherits UmbracoTemplatePage
<div id="fh5co-intro-section">
    <div class="container">
        <div class="row">
            <div class="col-md-8 col-md-offset-2 text-center">
                <h2>@Umbraco.AssignedContentItem.GetPropertyValue("PageTitle")</h2>
                <p><span>@umbraco.AssignedContentItem.GetPropertyValue("intro")</span> </p>
            </div>
        </div>
    </div>
</div>
