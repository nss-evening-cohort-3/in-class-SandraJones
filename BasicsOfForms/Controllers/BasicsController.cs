using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace BasicsOfForms.Controllers
{
    public class BasicsController : Controller
    {
        //GET
        public ActionResult Index()
        {
            int i = 0;
            return View();
        }
       
        public ActionResult Razor()
        {
            int j = 0;
            return View();
        }
    }
}
