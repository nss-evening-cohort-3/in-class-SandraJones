﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace BasicsOfForms.Controllers
{
    public class BasicsController : ApiController
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
