using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BasicsOfForms.Controllers
{
    public class AngularApiController : ApiController
    {
        public void Post(dynamic something)
        {
            int g = 0;
        }
     }
}
//Capture all the data from your form. Submit the data 
//to the Post method in your AngularApiController via an AJAX call.