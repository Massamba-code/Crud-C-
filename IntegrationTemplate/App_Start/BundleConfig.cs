using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IntegrationTemplate
{
    public class BundleConfig
    {
        // Pour plus d'informations sur le regroupement, visitez https://go.microsoft.com/fwlink/?LinkID=303951
        public static void RegisterBundles(BundleCollection bundles)
        {
            RegisterJQueryScriptManager();
            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/plugins/fontawesome-free/css/all.min.css",
                "~/Content/plugins/tempusdominus-bootstrap-4/css/tempusdominus-bootstrap-4.min.css",
                "~/Content/plugins/icheck-bootstrap/icheck-bootstrap.min.css",
                "~/Content/plugins/jqvmap/jqvmap.min.css",
                "~/Content/dist/css/adminlte.min.css",
                "~/Content/plugins/overlayScrollbars/css/OverlayScrollbars.min.css",
                "~/Content/plugins/daterangepicker/daterangepicker.css",
                "~/Content/plugins/summernote/summernote-bs4.min.css"
                
                ));
            bundles.Add(new StyleBundle("~/Scripts/js").Include(
              "~/Scripts/plugins/jquery/jquery.min.js",
              "~/Scripts/plugins/jquery-ui/jquery-ui.min.js",
              "~/Scripts/plugins/chart.js/Chart.min.js",
              "~/Scripts/plugins/sparklines/sparkline.js",
              "~/Scripts/plugins/jqvmap/jquery.vmap.min.js",
              "~/Scripts/plugins/jqvmap/maps/jquery.vmap.usa.js",
              "~/Scripts/plugins/jquery-knob/jquery.knob.min.js",
              "~/Scripts/plugins/moment/moment.min.js",
              "~/Scripts/plugins/daterangepicker/daterangepicker.js",
              "~/Scripts/plugins/tempusdominus-bootstrap-4/js/tempusdominus-bootstrap-4.min.js",
              "~/Scripts/plugins/summernote/summernote-bs4.min.js",
              "~/Scripts/plugins/overlayScrollbars/js/jquery.overlayScrollbars.min.js",
              "~/Scripts/dist/js/adminlte.js",
              "~/Scripts/dist/js/demo.js",
              "~/Scripts/dist/js/pages/dashboard.js"

              ));

            bundles.Add(new ScriptBundle("~/bundles/WebFormsJs").Include(
                            "~/Scripts/WebForms/WebForms.js",
                            "~/Scripts/WebForms/WebUIValidation.js",
                            "~/Scripts/WebForms/MenuStandards.js",
                            "~/Scripts/WebForms/Focus.js",
                            "~/Scripts/WebForms/GridView.js",
                            "~/Scripts/WebForms/DetailsView.js",
                            "~/Scripts/WebForms/TreeView.js",
                            "~/Scripts/WebForms/WebParts.js"));

            // L'ordre est très important pour que ces fichiers fonctionnent, car ils ont des dépendances explicites
            bundles.Add(new ScriptBundle("~/bundles/MsAjaxJs").Include(
                    "~/Scripts/WebForms/MsAjax/MicrosoftAjax.js",
                    "~/Scripts/WebForms/MsAjax/MicrosoftAjaxApplicationServices.js",
                    "~/Scripts/WebForms/MsAjax/MicrosoftAjaxTimer.js",
                    "~/Scripts/WebForms/MsAjax/MicrosoftAjaxWebForms.js"));

            // La version Development de Modernizr vous permet de développer et d’apprendre. Ensuite, lorsque vous êtes
            // prêt pour la production, utilisez l'outil de génération à l'adresse https://modernizr.com pour sélectionner uniquement les tests dont vous avez besoin
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                            "~/Scripts/modernizr-*"));
        }

        public static void RegisterJQueryScriptManager()
        {
            ScriptManager.ScriptResourceMapping.AddDefinition("jquery",
                new ScriptResourceDefinition
                {
                    Path = "~/scripts/jquery-3.7.0.min.js",
                    DebugPath = "~/scripts/jquery-3.7.0.js",
                    CdnPath = "http://ajax.aspnetcdn.com/ajax/jQuery/jquery-3.7.0.min.js",
                    CdnDebugPath = "http://ajax.aspnetcdn.com/ajax/jQuery/jquery-3.7.0.js"
                });
        }
    }
}