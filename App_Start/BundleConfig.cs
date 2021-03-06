﻿using System.Web;
using System.Web.Optimization;

namespace Ugb
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            //bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
            //            "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                       "~/Scripts/jquery.min.js",
                        "~/Scripts/jquery-ui-1.10.3.min.js"
                       ));

            bundles.Add(new ScriptBundle("~/bundles/script").Include(
                       "~/Scripts/bootstrap.min.js",
                       "~/Scripts/raphael-min.js",
                       "~/Scripts/AdminLTE/app.js",
                       "~/Scripts/AdminLTE/dashboard.js"));



            //bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
            //            "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            //bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
            //            "~/Scripts/modernizr-*"));

            //bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
            //          "~/Scripts/bootstrap.js"));

            //bundles.Add(new StyleBundle("~/Content/css").Include(
            //          "~/Content/bootstrap.css",
            //          "~/Content/site.css"));


            bundles.Add(new StyleBundle("~/Content/css").Include(
                     "~/Content/bootstrap.min.css",
                     "~/Content/font-awesome.min.css",
                     "~/Content/ionicons.min.css",
                     "~/Content/morris/morris.css",
                     "~/Content/jvectormap/jquery-jvectormap-1.2.2.css",
                     "~/Content/fullcalendar/fullcalendar.css",
                     "~/Content/daterangepicker/daterangepicker-bs3.css",
                     "~/Content/bootstrap-wysihtml5/bootstrap3-wysihtml5.min.css",
                     "~/Content/AdminLTE.css"));
        }
    }
}
