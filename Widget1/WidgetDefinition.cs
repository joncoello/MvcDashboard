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
    }
}