using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace LearnMVC.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/admin/styles")
                .Include("~/content/bootstrap.css")
                .Include("~/content/site.css"));

            bundles.Add(new StyleBundle("~/styles")
               .Include("~/content/bootstrap.css")
               .Include("~/content/site.css"));


            bundles.Add(new ScriptBundle("~/scripts")
              .Include("~/Scripts/jquery-1.10.2.min.js")
              .Include("~/Scripts/bootstrap.min.js"));
        }
    }
}