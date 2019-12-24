@Imports Umbraco.Web.Mvc.UmbracoTemplatePage
@Code
    Layout = Nothing
End Code

<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0, shrink-to-fit=no">
    <title>worksync</title>
    <link rel="stylesheet" href="~/assets/bootstrap/css/bootstrap.min.css">
    <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Aclonica">
    <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Amaranth">
    <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Playfair+Display">
    <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Poppins">
    <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Roboto">
    <link rel="stylesheet" href="~/assets/fonts/fontawesome-all.min.css">
    <link rel="stylesheet" href="~/assets/css/Article-List.css">
    <link rel="stylesheet" href="~/assets/css/bootstrap.min.css">
    <link rel="stylesheet" href="~/assets/css/styles.css">
</head>
<body>
    @RenderSection("ScriptsTop", False)
    @Code
        Html.RenderAction("RenderHeader", "SiteLayout")
        Html.RenderAction("RenderTitle", "SiteLayout")
        RenderBody()
        Html.RenderAction("RenderFooter", "SiteLayout")
    End Code
    <script src="~/assets/js/jquery.min.js"></script>
    <script src="~/assets/bootstrap/js/bootstrap.min.js"></script>
    @RenderSection("ScriptsBottom", False)
    <!-- ScriptsEnd JS -->
    @RenderSection("ScriptsEnd", False)
</body>
</html>


