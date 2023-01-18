using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Tree_1._0.Controllers
{
    public class HomeController : Controller
    {
        

        public ActionResult Index()
        {
            ViewData["ProductTitle"] = "Contact";
            return View();
        }

        public ActionResult cInsercion()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Contact2()
        {
            ViewData["ProductTitle"] = "Contact2";
            return View();
        }

        public ActionResult Prueba()
        {
            ViewData["ProductTitle"] = "Contact";
            return View();
        }
    }
}