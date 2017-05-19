using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcDashboard.Models
{
    public class HomeModel
    {
        public string PageTitle { get; set; }

        public List<HomeWidget> Widgets { get; set; }

        public HomeModel()
        {
            Widgets = new List<HomeWidget>();
        }

    }

    public class HomeWidget {

        public string Template { get; set; }

    }

}