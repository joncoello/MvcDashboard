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
            return Widget2.Properties.Resources.script;
        }

        public List<string> GetScriptReferences()
        {
            var refs = new List<string>();
            //refs.Add("<script src=\"https://code.jquery.com/jquery-3.2.1.min.js\"></script>");
            refs.Add("<script src=\"https://cdnjs.cloudflare.com/ajax/libs/bootstrap-datepicker/1.6.4/js/bootstrap-datepicker.min.js\"></script>");
            refs.Add("<script src=\"https://cdnjs.cloudflare.com/ajax/libs/bootstrap-progressbar/0.9.0/bootstrap-progressbar.min.js\"></script>");
            return refs;
        }

        public string GetStyle()
        {
            return Widget2.Properties.Resources.style;
        }

        public List<string> GetStyleReferences()
        {
            var styles = new List<string>();
            styles.Add("<link href=\"https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css\" rel=\"stylesheet\" />");
            styles.Add("<link href=\"https://maxcdn.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css\" rel=\"stylesheet\" />");
            styles.Add("<link rel=\"stylesheet\" href=\"https://cdnjs.cloudflare.com/ajax/libs/bootstrap-datepicker/1.6.4/css/bootstrap-datepicker.min.css\" />");
            return styles;
        }
    }
}