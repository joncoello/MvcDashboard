using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EnterHolidayWidget
{
    public class WidgetDefinition : MvcDashboard.Contracts.IWidget
    {
        public string GetHtml()
        {
            return EnterHolidayWidget.Properties.Resources.index;
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

        public string GetStyle()
        {
            return "";
        }

        public List<string> GetStyleReferences()
        {
            return new List<string>();
        }
    }
}