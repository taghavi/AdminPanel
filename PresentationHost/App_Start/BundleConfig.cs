using System.Web;
using System.Web.Optimization;

namespace PresentationHost
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));
            bundles.Add(new ScriptBundle("~/bundles/Angular").Include(
                      "~/Scripts/angular.min.js", "~/Scripts/angular-animate.min.js", "~/Scripts/angular-aria.min.js",
                      "~/Scripts/angular-messages.min.js",
                      "~/Scripts/angular-route.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/apps").Include(
                      "~/Modules/app/app.js", "~/Modules/app/routes.js",
                      "~/Modules/bookGrid/bookController.js", "~/Modules/bookGrid/pagination.js"));

            //bundles.Add(new ScriptBundle("~/bundles/Grid").Include("~/Scripts/DataGrid/dataGrid.js", 
            //    "~/Scripts/DataGrid/pagination.js"));
            //bundles.Add(new ScriptBundle("~/bundles/Table").Include("~/Scripts/SmartTable/smart-table.js"));

            bundles.Add(new ScriptBundle("~/bundles/kendo").Include("~/Scripts/kendo/js/kendo.all.min.js", "~/Scripts/kendo/js/kendo.angular.min.js",
                "~/Scripts/kendo/js/messages/kendo.fa-IR.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css", "~/Content/Custom.css","~/Content/kendo/styles/kendo.common.min.css","~/Content/kendo/styles/kendo.silver.min.css",
                      "~/Content/kendo/styles/kendo.rtl.min.css","~/Content/site.css"));
#if !DEBUG
            BundleTable.EnableOptimizations = true;
#endif
        }
    }
}
