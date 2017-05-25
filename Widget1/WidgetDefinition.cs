using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcDashboard.Contracts;

namespace Widget1
{
    public class WidgetDefinition : MvcDashboard.Contracts.IWidget
    {
        public string GetHtml()
        {
            return Widget1.Properties.Resources.index;
        }

        public WidgetLayout Getlayout()
        {
            return new WidgetLayout() {
                X = 4,
                Y = 5,
                Widh = 4,
                Height = 5
            };
        }

        public string GetScript()
        {
            return Widget1.Properties.Resources.script;
        }

        public List<string> GetScriptReferences()
        {
            var refs = new List<string>();
            refs.Add("<script src=\"https://cdnjs.cloudflare.com/ajax/libs/Chart.js/2.5.0/Chart.bundle.min.js\"></script>");
            return refs;
        }

        public string GetStyle()
        {
            return "";
        }

        public List<string> GetStyleReferences()
        {
            return new List<string>();
        }

        public bool HasAuthority()
        {
            return false;
        }
    }
}