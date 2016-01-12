using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MGEX_BackOffice_EF6.Models;
using MGEX_BackOffice_EF6.DAL;

namespace MGEX_BackOffice_EF6.Controllers
{
    public class HomeController : Controller
    {
        private WheatLastDBContext db = new WheatLastDBContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Wheat()
        {
            ProductViewModel model = new ProductViewModel();
            model.SpreadList = db.getLastRecords("sp_BO_LAST_sel");
            return View(model);
        }

        public ActionResult AJC()
        {
            ProductViewModel model = new ProductViewModel();
            model.SpreadList = db.getLastRecords("sp_BO_AJC_LAST_sel");
            return View(model);
        }

        public ActionResult Indexes()
        {
            ViewBag.Message = "Agricultural Indexes.";

            return View();
        }

    }
}