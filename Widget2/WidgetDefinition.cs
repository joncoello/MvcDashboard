using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Widget2
{
    public class WidgetDefinition : MvcDashboard.Contracts.IWidget
    {
        public string GetHtml()
        {
            return Widget2.Properties.Resources.index;
        }

        public string GetScript()
        {
            return "";
        }

        public List<string> GetScriptReferences()
        {
            var refs = new List<string>();
            return refs;
        }
    }
}