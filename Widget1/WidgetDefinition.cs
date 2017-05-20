using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Widget1
{
    public class WidgetDefinition : MvcDashboard.Contracts.IWidget
    {
        public string GetHtml()
        {
            return Widget1.Properties.Resources.index;
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
    }
}