using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace First_MVC.Controllers
{
    public class HttpController : Controller
    {
        // GET: Http
        public HttpStatusCodeResult Index()
        {
            //return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadGateway);                        ////
            return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadGateway,"BAD GATEWAY HATASI");     //// Üçü de aynı işe yarar
           // return new HttpStatusCodeResult(502);                                                           ////
        }

        public HttpStatusCodeResult Index2()
        {
           // return new HttpUnauthorizedResult();
            return new HttpUnauthorizedResult("Yetkisiz giris");
        }
        public HttpStatusCodeResult Index3()
        {
           // return HttpNotFound();
           // return HttpNotFound("Bu sayfa bulunamadı");
            return new HttpNotFoundResult();
        }
    }
}