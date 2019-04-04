using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
namespace App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/bundles/css/bs").IncludeDirectory("~/css/bs", "*.css", true));
            bundles.Add(new StyleBundle("~/bundles/css/jqueryui").Include("~/css/jqui/jquery-ui.css", new CssRewriteUrlTransform()));
            bundles.Add(new StyleBundle("~/bundles/css/fa").Include("~/css/fa/fa.css", new CssRewriteUrlTransform()));
            bundles.Add(new StyleBundle("~/bundles/css/pc").Include("~/css/pc/pc.css"));


            bundles.Add(new ScriptBundle("~/bundles/jq").IncludeDirectory("~/js/jq/", "*.js", true));
            bundles.Add(new ScriptBundle("~/bundles/jqui").IncludeDirectory("~/js/jqui/", "*.js", true));
            bundles.Add(new ScriptBundle("~/bundles/bs").IncludeDirectory("~/js/bs/", "*.js", true));
            bundles.Add(new ScriptBundle("~/bundles/pc").IncludeDirectory("~/js/pc/", "*.js", true));
            BundleTable.EnableOptimizations = true; 
        }
    }
}