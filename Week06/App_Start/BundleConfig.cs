using System.Web;
using System.Web.Optimization;

namespace Week06
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

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            // Normally people would avoid installing the whole JQueryUI bundle.
            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                      "~/Scripts/jquery-ui-{version}.js"));

            // Normally people will not try to mix and match UI libraries since it is by default using bootstrap.
            // There is NOTHiNG wrong with using the jquery ui library though.
            bundles.Add(new StyleBundle("~/Content/jqueryui").Include(
                      "~/Content/themes/base/jquery-ui.min.css"));

            bundles.Add(new ScriptBundle("~/bundles/site").Include(
                      "~/Scripts/site.js"));

            
            bundles.Add(new ScriptBundle("~/bundles/datatables").Include(
                      "~/Scripts/DataTables/jquery.dataTables.min.js"));
            
            // If you do not load the CSS, you will realise that there are some missing icons. (Where you can
            // Click sort and etc. Here I will load the boostrap CSS as well instead of the the jquery ui css.
            bundles.Add(new StyleBundle("~/Content/datatables").Include(
                     "~/Content/DataTables/css/dataTables.bootstrap.min.css"));

        }
    }
}
