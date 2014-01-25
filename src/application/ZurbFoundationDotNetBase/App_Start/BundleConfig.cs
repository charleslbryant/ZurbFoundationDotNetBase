using System.Web;
using System.Web.Optimization;

namespace ZurbFoundationDotNetBase
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/site.css"));

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
              "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
              "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/foundation").Include(
              "~/Scripts/foundation/foundation.js",
              "~/Scripts/foundation/foundation.*"));
        }
    }
}