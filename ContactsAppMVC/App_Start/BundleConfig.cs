using System.Web;
using System.Web.Optimization;

// Bundle Config is used to initialize all the needed js , css , bootstrap etc.

namespace ContactsAppMVC
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/js/lib1/jquery.min.js"));


            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/js/lib1/bootstrap.min.js"));


            bundles.Add(new ScriptBundle("~/bundles/datatables").Include(
                        "~/js/lib1/jquery.dataTables.min.js",
                        "~/js/lib1/dataTables.bootstrap.min.js",
                        "~/js/lib1/dataTables.colReorder.min.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/css/bootstrap.min.css",
                     "~/css/jquery.dataTables.min.css",
                     "~/css/jquery.dataTables_themeroller.css",
                      "~/css/dataTables.bootstrap.min.css",
                      "~/css/colReorder.bootstrap.min.css",
                      "~/css/site.css"));

            /*            // Use the development version of Modernizr to develop with and learn from. Then, when you're
                        // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
                        bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                                    "~/Scripts/modernizr-*"));
                                    */


        }
    }
}
