using System.Web;
using System.Web.Optimization;

namespace DrawNet.Draw
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

            bundles.Add( new ScriptBundle( "~/bundles/application" ).Include(
                "~/Scripts/app.min.js",
                "~/Scripts/demo.js" ) );


            bundles.Add(new ScriptBundle("~/bundles/plugins").Include(
                "~/Content/plugins/fastclick/fastclick.min.js",
                "~/Content/plugins/slimScroll/jquery.slimscroll.min.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/helpers.css",
                      "~/Content/plugins/fontAwesome/css/font-awesome.min.css",
                      "~/Content/plugins/ionicons/css/ionicons.css",
                      "~/Content/AdminLTE.css",
                      "~/Content/skins/_all-skins.css",
                      "~/Content/sprites.css",
                      "~/Content/site.css"));
        }
    }
}
