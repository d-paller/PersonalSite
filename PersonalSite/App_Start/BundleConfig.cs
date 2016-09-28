using System.Web;
using System.Web.Optimization;

namespace PersonalSite.Web
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            // JS
            bundles.UseCdn = true;
            bundles.Add(new ScriptBundle("~/bundles/jquery", "https://code.jquery.com/jquery-3.1.1.min.js")
                .Include("~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/modernizer", "http://ajax.aspnetcdn.com/ajax/modernizr/modernizr-2.8.3.js")
                .Include("~/Scripts/modernizer-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap", "http://ajax.aspnetcdn.com/ajax/bootstrap/3.3.7/bootstrap.min.js")
                .Include("~/Scripts/bootstrap.js"));

            bundles.Add(new ScriptBundle("~/bundles/javascript")
                .Include("~/Scripts/CustomScript.js")
                .Include("~/Scripts/Tracking.js"));

            // Styles
            bundles.Add(new StyleBundle("~/bundles/css")
                .Include("~/Content/Style.less"));

            bundles.Add(new StyleBundle("~/bundles/bootstrapcss", "http://ajax.aspnetcdn.com/ajax/bootstrap/3.3.7/css/bootstrap.min.css")
                .Include("~/Content/bootstrap.min.css"));

            bundles.Add(new StyleBundle("~/bundles/bs-theme", "http://ajax.aspnetcdn.com/ajax/bootstrap/3.3.7/css/bootstrap-theme.min.css")
                .Include("~/Content/bootstrap-theme.min.css"));



            // Overrides web.config to allow bundling
            BundleTable.EnableOptimizations = true;
        }
    }
}