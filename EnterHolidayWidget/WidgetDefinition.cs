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
            return EnterHolidayWidget.Properties.Resources.script;
        }

        public List<string> GetScriptReferences()
        {
            var refs = new List<string>();
            refs.Add("<script type=\"text/javascript\" src=\"//cdn.jsdelivr.net/momentjs/latest/moment.min.js\"></script>");
            refs.Add("<script type=\"text/javascript\" src=\"//cdn.jsdelivr.net/bootstrap.daterangepicker/2/daterangepicker.js\"></script>");
            return refs;
        }

        public string GetStyle()
        {
            return "";
        }

        public List<string> GetStyleReferences()
        {
            var styles = new List<string>();
            styles.Add("<link href=\"https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css\" rel=\"stylesheet\" />");
            styles.Add("<link href=\"//cdn.jsdelivr.net/bootstrap.daterangepicker/2/daterangepicker.css\" rel=\"stylesheet\" />");
            return styles;
        }
    }
}