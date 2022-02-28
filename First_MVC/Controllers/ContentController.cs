using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace First_MVC.Controllers
{
    public class ContentController : Controller
    {
        // GET: Home
        // return Content("Zehra Kıran");
        public ContentResult Index()
        {
            return Content("<b>Zehra kiran</b>", "text/html ,charset=utf-8");
        }


        public ContentResult Index2()
        {
            return Content("<b>Emine Koşak</b>", "text/plain ");
        }

        public ContentResult Index3()
        {
            var xml = "<proucts>" + "<product><name>PC</name></prouct>" + "<product><name>mouse</name></prouct>" + "</products>";
            return Content(xml, "application/xml ");
        }
    }
}
