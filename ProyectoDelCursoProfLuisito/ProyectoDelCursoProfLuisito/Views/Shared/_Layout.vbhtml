<!DOCTYPE html>
<html>
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>@ViewBag.Title - Mi aplicación ASP.NET</title>
    @Styles.Render("~/Content/css")
    <link href="~/Content/bootstrap.css" rel="stylesheet" />
    <link href="~/Content/Site.css" rel="stylesheet" />
    @Scripts.Render("~/bundles/modernizr")

</head>
<body>
    <div class="navbar navbar-inverse navbar-fixed-top">
        <div class="container">
            <div class="navbar-header">
         
                @Html.ActionLink("TipoUsuarios", "Index", "TipoUsuario", New With {.area = ""}, New With {.class = "navbar-brand"})
                @Html.ActionLink("Personas", "Index", "Personas", New With {.area = ""}, New With {.class = "navbar-brand"})
                @Html.ActionLink("Medicamentos", "Index", "Medicamentos", New With {.area = ""}, New With {.class = "navbar-brand"})
                @Html.ActionLink("Mascotas", "Index", "Mascotas", New With {.area = ""}, New With {.class = "navbar-brand"})
                @Html.ActionLink("Paginas", "Index", "Pagina", New With {.area = ""}, New With {.class = "navbar-brand"})

            </div>
            <div class="navbar-collapse collapse">
                <ul class="nav navbar-nav">
                    <li>@Html.ActionLink("Inicio", "Index", "Home")</li>
                    <li>@Html.ActionLink("Acerca de", "About", "Home")</li>
                    <li>@Html.ActionLink("Contacto", "Contact", "Home")</li>
                </ul>
                @Html.Partial("_LoginPartial")
            </div>
        </div>
    </div>
    <div class="container body-content">
        @RenderBody()
        <hr />
        <footer>
            <p>&copy; @DateTime.Now.Year - Mi aplicación ASP.NET</p>
        </footer>
    </div>

    @RenderSection("scripts", required:=False)
</body>
</html>
