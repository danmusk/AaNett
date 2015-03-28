using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AaNett.Web.Controllers
{
    public class ArticleController : Controller
    {
        public ActionResult Index()
        {
            return View("Geocaching");
        }
        public ActionResult PostkasseBlasteOpp()
        {
            return View();
        }


    }
}