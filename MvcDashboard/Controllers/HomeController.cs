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

        private string GetBody(string html)
        {
            
            var pattern = "<!--bodystart-->(.*?)<!--bodyend-->";
            var regex = new Regex(pattern, RegexOptions.Singleline);
            var match = regex.Match(html);
            var value = match.Value;

            return value;
        }

    }
}