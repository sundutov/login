using System.Web.Optimization;

namespace ReportingLogin
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/css")
                .Include("~/Content/site.css"));
            bundles.Add(new ScriptBundle("~/bundles/MyApp")
                .Include("~/Scripts/angular.js")
                .Include("~/Scripts/angular-route.js")
                .IncludeDirectory("~/Scripts/Controllers", "*.js")
                .IncludeDirectory("~/Scripts/Factories", "*.js")
                .Include("~/Scripts/MyApp.js"));
        }
    }
}
