using MvcDashboard.Models;
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
        private static string _layout = "name:holiday-widget;x:0;y:0;width:9;height:3,name:bar-chart-widget;x:4;y:3;width:4;height:5,name:calendar-widget;x:9;y:0;width:2;height:5";

        public string Get() {
            return _layout;
        }

        public void Post([FromBody]DashboardLayout layout)
        {
            _layout = layout.Layout;
        }

    }
}
