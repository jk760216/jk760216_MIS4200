using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace jk760216_MIS4200.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "About Jack Koch";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact information for Jack Koch";

            return View();
        }
    }
}