using MvcDashboard.Models;
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
                PageTitle = "Dashboard"
            };
            model.Widgets.Add(CreateWidget());
            model.Widgets.Add(CreateWidget());
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

        private HomeWidget CreateWidget() {

            var widget = new Models.HomeWidget
            {
                Template = MvcDashboard.Properties.Resources.chart1html,
                Script = MvcDashboard.Properties.Resources.chart1js
            };
            widget.ScriptReferences.Add("<script src=\"https://cdnjs.cloudflare.com/ajax/libs/Chart.js/2.5.0/Chart.bundle.min.js\"></script>");

            return widget;
        }

    }
}