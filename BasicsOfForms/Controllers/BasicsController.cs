using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BasicsOfForms.Controllers
{
    public class BasicsController : Controller
    {
        // GET: Basics
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(FormCollection form)
        {
            int i = 0;
            return View();
        }
        
        public ActionResult Razor()
        {
            int j = 0;
            return View();
        }

        //adding a breakpoint on line 33 allows me to check for elements in the form to see that it worked.
        [HttpPost]
        public ActionResult Razor(FormCollection form)
        {
            int j = 0;
            return View();
        }
        public ActionResult Angular()
        {
            int k = 0;
            return View();
        }


        //don't know if I need this or not
        [HttpPost]
        public ActionResult Angular(FormCollection form)
        {
            int k = 0;
            return View();
        }
    }
}