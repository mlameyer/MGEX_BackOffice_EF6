using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MGEX_BackOffice_EF6.Controllers
{
    public class SettlementsController : Controller
    {
        // GET: Settlements
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AJCSettlement()
        {
            return View();
        }

        public ActionResult WheatSettlement()
        {
            return View();
        }
    }
}