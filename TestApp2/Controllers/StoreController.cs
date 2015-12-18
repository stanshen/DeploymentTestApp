using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace TestApp2.Controllers
{
    public class StoreController : ApiController
    {
        public string Get()
        {
            return "stores";
        }
    }
}