using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TestApp2.Controllers
{
    public class StaffController : ApiController
    {
        public List<string> Get()
        {
            return new List<string>() { "store 1", "store 2" };
        }
    }
}
