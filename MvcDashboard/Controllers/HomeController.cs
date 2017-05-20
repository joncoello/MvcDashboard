using MvcDashboard.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
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

            var widgets = MefBootstrapper.GetInstances<MvcDashboard.Contracts.IWidget>();
            foreach (var widget in widgets)
            {
                model.Widgets.Add(new Models.HomeWidget
                {
                    Template = GetBody(widget.GetHtml()),
                    Script = widget.GetScript(),
                    ScriptReferences = widget.GetScriptReferences()
                });
            }

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

        private string GetBody(string html)
        {
            
            //var pattern = "#<!--body-->(.*?)<!--/body-->#";
            var pattern = "<!--bodystart-->(.*?)<!--bodyend-->";
            var regex = new Regex(pattern, RegexOptions.Singleline);
            var match = regex.Match(html);
            var value = match.Value;

            return value;
        }

    }
}