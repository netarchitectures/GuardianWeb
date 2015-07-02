using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace Ltd.NA.FrontEnd
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery")
                .Include(
                    "~/Scripts/jquery-{version}.js",
                    "~/Scripts/slider.js"));

            bundles.Add(new StyleBundle("~/Content/css")
                .Include(
                    "~/Content/site.css",
                    "~/Content/slider.css"));

            BundleTable.EnableOptimizations = false;
        }
    }
}