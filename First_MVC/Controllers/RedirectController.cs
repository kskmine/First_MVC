using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace First_MVC.Controllers
{
    public class RedirectController : Controller
    {
        // GET: Redirect
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Index2()
        {
            // return View("~/view");
            // return Redirect("http://www.turgutergovan.com");

            return View("~/javascript/Index");
        }

        public ActionResult Index3()
        {
            // return RedirectToAction("Index", new {Controller = "view", "id "= "5"}) ; ///Sık kullanılır

            return RedirectToAction("Index", new RouteValueDictionary()

            {
                {" Controller" ,"view" },
                 {" id" ,"6" },
            }
            );
        }
    }
}