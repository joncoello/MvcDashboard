using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcDashboard.Models
{
    public class HomeModel
    {
        public string PageTitle { get; set; }

        public List<string> ControlTemplates { get; set; }

        public HomeModel()
        {
            ControlTemplates = new List<string>();
        }

    }
}