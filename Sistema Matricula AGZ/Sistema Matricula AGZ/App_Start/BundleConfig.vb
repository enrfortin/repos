Imports System.Web.Optimization

Public Module BundleConfig
    ' Para obtener más información sobre Bundles, visite http://go.microsoft.com/fwlink/?LinkId=301862
    Public Sub RegisterBundles(ByVal bundles As BundleCollection)

        bundles.Add(New ScriptBundle("~/bundles/jquery").Include(
                    "~/Scripts/jquery-{version}.js"))

        bundles.Add(New ScriptBundle("~/bundles/jqueryval").Include(
                    "~/Scripts/jquery.validate*"))

        ' Utilice la versión de desarrollo de Modernizr para desarrollar y obtener información. De este modo, estará
        ' preparado para la producción y podrá utilizar la herramienta de compilación disponible en http://modernizr.com para seleccionar solo las pruebas que necesite.
        bundles.Add(New ScriptBundle("~/bundles/modernizr").Include(
                    "~/Scripts/modernizr-*"))

        bundles.Add(New ScriptBundle("~/bundles/bootstrap").Include(                
                                    "~/Content/plugins/jquery/jquery.min.js",
                                    "~/Content/plugins/bootstrap/js/bootstrap.bundle.min.js",
                                    "~/Content/plugins/overlayScrollbars/js/jquery.overlayScrollbars.min.js",
                                    "~/Content/dist/js/adminlte.js",
                                    "~/Content/plugins/jquery-mousewheel/jquery.mousewheel.js",
                                    "~/Content/plugins/raphael/raphael.min.js",
                                    "~/Content/plugins/jquery-mapael/jquery.mapael.min.js",
                                    "~/Content/plugins/jquery-mapael/maps/usa_states.min.js",
                                    "~/Content/plugins/chart.js/Chart.min.js",
                                    "~/Content/dist/js/demo.js",
                                    "~/Content/dist/js/pages/dashboard2.js"))

        bundles.Add(New StyleBundle("~/Content/css").Include(
                  "~/Content/plugins/fontawesome-free/css/all.min.css",
                  "~/Content/plugins/overlayScrollbars/css/OverlayScrollbars.min.css",
                  "~/Content/dist/css/adminlte.min.css"))
    End Sub
End Module

