using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ViewAbsenceWidget
{
    public class WidgetDefinition : MvcDashboard.Contracts.IWidget
    {
        public string GetHtml()
        {
            return ViewAbsenceWidget.Properties.Resources.index;
        }

        public string GetScript()
        {
            return ViewAbsenceWidget.Properties.Resources.script;
        }

        public List<string> GetScriptReferences()
        {
            var refs = new List<string>();
            return refs;
        }

        public string GetStyle()
        {
            return ViewAbsenceWidget.Properties.Resources.style;
        }

        public List<string> GetStyleReferences()
        {
            return new List<string>();
        }
    }
}