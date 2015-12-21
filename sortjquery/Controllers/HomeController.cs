using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SortJquery.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {            
            return View();
        }
        public JsonResult GetData()
        {
            var data= "[{\"Yıl\":2014,\"data\":[{\"Makale\":\"Mvc Nedir?\",\"UniqeUser\":45683}]},{\"Yıl\":2014,\"data\":[{\"Makale\":\"Html Tag Cache\",\"UniqeUser\":44385}]},{\"Yıl\":2015,\"data\":[{\"Makale\":\"Multi Upload Files\",\"UniqeUser\":62345}]},{\"Yıl\":2015,\"data\":[{\"Makale\":\"Node Js\",\"UniqeUser\":112000}]},{\"Yıl\":2014,\"data\":[{\"Makale\":\"Iframe Nedir\",\"UniqeUser\":57245}]},{\"Yıl\":2014,\"data\":[{\"Makale\":\"SignalR Nedir\",\"UniqeUser\":157815}]},{\"Yıl\":2015,\"data\":[{\"Makale\":\"AngularJS Nedir\",\"UniqeUser\":95683}]},{\"Yıl\":2014,\"data\":[{\"Makale\":\"KnockoutJS Nedir\",\"UniqeUser\":67341}]},{\"Yıl\":2015,\"data\":[{\"Makale\":\"Jquery Sort\",\"UniqeUser\":25000}]},{\"Yıl\":2015,\"data\":[{\"Makale\":\"Ses Teknlojileri\",\"UniqeUser\":43768}]}]";
            return Json(data,JsonRequestBehavior.AllowGet);
        }
    }
}