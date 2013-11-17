using System.Web;
using System.Web.Optimization;

namespace AaNett.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/scripts/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new StyleBundle("~/content/css").Include(
                      "~/Content/componentsCommon.css",
                      "~/Content/componentsNormal.css",
                      "~/Content/normal.css",
                      "~/Content/multifix.css"));
        }
    }
}
