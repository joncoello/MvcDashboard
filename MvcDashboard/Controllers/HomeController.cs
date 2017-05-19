using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcDashboard.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var model = new Models.HomeModel{
                PageTitle = "Hello MVC"
            };
            model.Widgets.Add(new Models.HomeWidget {
                Template = MvcDashboard.Properties.Resources.chart1html,
                Script = MvcDashboard.Properties.Resources.chart1js
            });
            model.Widgets.Add(new Models.HomeWidget {
                Template= "<div><h1>booooo</h1></div>"
            });
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}