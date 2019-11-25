
using System.Web;
using System.Web.Optimization;
using WebHelpers.Mvc5;


namespace Pidev.web
{
    public class BundleConfig
    {
       
        public static void RegisterBundles(BundleCollection bundles)
        {

          

           

          
         


            #region Template
            bundles.Add(new ScriptBundle("~/template/js")
                   .Include("~/Content/vendor/modernizr/modernizr.custom.js")
                .Include("~/Content/vendor/js-storage/js.storage.js")
                .Include("~/Content/vendor/screenfull/dist/screenfull.js")
                .Include("~/Content/vendor/i18next/i18next.js")
                .Include("~/Content/vendor/i18next-xhr-backend/i18nextXHRBackend.js")
                .Include("~/Content/vendor/jquery/dist/jquery.js")
                .Include("~/Content/vendor/popper.js/dist/umd/popper.js")
                .Include("~/Content/vendor/bootstrap/dist/js/bootstrap.js")
                .Include("~/Content/vendor/jquery-slimscroll/jquery.slimscroll.js")
                .Include("~/Content/vendor/jquery-sparkline/jquery.sparkline.js")
                .Include("~/Content/vendor/flot/jquery.flot.js")
                .Include("~/Content/vendor/jquery.flot.tooltip/js/jquery.flot.tooltip.js")
                .Include("~/Content/vendor/flot/jquery.flot.resize.js")
                .Include("~/Content/vendor/flot/jquery.flot.pie.js")
                .Include("~/Content/vendor/flot/jquery.flot.time.js")
                .Include("~/Content/vendor/flot/jquery.flot.categories.js")
                .Include("~/Content/vendor/jquery.flot.spline/jquery.flot.spline.js")
                .Include("~/Content/vendor/easy-pie-chart/dist/jquery.easypiechart.js")
                .Include("~/Content/vendor/moment/min/moment-with-locales.js")
                 .Include(
                     "~/Content/js/app.js"));

           


            #endregion

#if DEBUG
            BundleTable.EnableOptimizations = false;
#else
            BundleTable.EnableOptimizations = true;
#endif

        }
    }
}
