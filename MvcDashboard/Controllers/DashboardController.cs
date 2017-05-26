using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MvcDashboard.Controllers
{
    public class DashboardController : ApiController
    {
        public string Get() {
            return "hello";
        }
    }
}
