using System.Web;
using System.Web.Optimization;

namespace Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery.min.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.min.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/webpet").Include(
                        "~/Scripts/detect.js",
                        "~/Scripts/fastclick.js",
                        "~/Scripts/jquery.slimscroll.js",
                        "~/Scripts/jquery.blockUI.js",
                        "~/Scripts/waves.js",
                        "~/Scripts/wow.min.js",
                        "~/Scripts/jquery.nicescroll.js",
                        "~/Scripts/jquery.scrollTo.min.js",
                        "~/Scripts/jquery.peity.min.js",
                        "~/Scripts/jquery.waypoints.js",
                        "~/Scripts/jquery.counterup.min.js",
                        //"~/Scripts/morris.min.js",
                        "~/Scripts/raphael-min.js",
                        "~/Scripts/jquery.knob.js",
                        //"~/Scripts/jquery.dashboard.js",
                        "~/Scripts/jquery.core.js",
                        "~/Scripts/jquery.app.js",
                        "~/Scripts/jquery.dataTables.min.js",
                        "~/Scripts/sweetalert.min.js"
                     
                ));

            bundles.Add(new ScriptBundle("~/bundles/angular").Include(
               "~/Scripts/angular/angular.min.js",
               "~/Scripts/angular/app.js",
               "~/Scripts/angular/angular-sanitize.min.js",
               "~/Scripts/angular/ui-bootstrap.min.js",
               "~/Scripts/angular/ui-bootstrap-tpls.min.js",
               "~/Scripts/angular/angular-animate.min.js",
               "~/Scripts/angular/mask.js",
               "~/Scripts/angular/angular-input-masks-standalone.min.js",
               "~/Scripts/angular/angular-locale_pt-br.js",
               "~/Scripts/angular/dirPagination.js",
               "~/Scripts/angular/ng-file-upload.js"));

            bundles.Add(new ScriptBundle("~/bundles/controller").Include(
              "~/Scripts/Controllers/UsuarioController.js"
             ));


            //bundles.Add(new StyleBundle("~/Content/css").Include(
            //          "~/Content/bootstrap.css",
            //          "~/Content/site.css"
                      
            //          ));

            bundles.Add(new StyleBundle("~/Content/bootstrap_css").Include(
                "~/Content/Css/morris.css",
                "~/Content/Css/bootstrap.min.css",
                "~/Content/Css/core.css",
                "~/Content/Css/components.css",
                "~/Content/Css/icons.css",
                "~/Content/Css/pages.css",
                "~/Content/Css/responsive.css",
                "~/Content/Css/jquery.dataTables.min.css",
                "~/Content/Css/sweetalert.min.css"

                ));

        }
    }
}
