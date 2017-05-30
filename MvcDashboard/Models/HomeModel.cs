using MvcDashboard.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcDashboard.Models
{
    public class HomeModel
    {
        public string PageTitle { get; set; }

        public List<HomeWidget> Widgets { get; set; }

        public HomeModel()
        {
            Widgets = new List<HomeWidget>();
        }

    }

    public class HomeWidget
    {

        public Guid ID { get; set; }

        private string _template;
        public string Template
        {
            get
            {
                return _template;
            }
            set
            {
                _template = ReplaceThisWithID(value);
            }
        }

        private string _script;
        public string Script
        {
            get
            {
                return _script;
            }
            set
            {
                _script = ReplaceThisWithID(value);
            }
        }

        private string _style;
        public string Style {
            get
            {
                return _style;
            }
            set
            {
                _style = ReplaceThisWithID(value);
            }
        }

        public List<string> ScriptReferences { get; set; }

        public List<string> StyleReferences { get; set; }

        public WidgetLayout Layout { get; set; }

        private static HomeWidget _notAuthorisedWidget;
        public static HomeWidget NotAuthorisedWidget
        {
            get
            {
                if (_notAuthorisedWidget == null)
                {
                    _notAuthorisedWidget = new HomeWidget()
                    {
                        Template = "<h1>not authoised</h1>",
                        Layout = new WidgetLayout() {
                            Widh = 2,
                            Height = 2
                        }
                    };
                }
                return _notAuthorisedWidget;
            }
        }

        public HomeWidget()
        {
            ID = Guid.NewGuid();
            ScriptReferences = new List<string>();
            StyleReferences = new List<string>();
        }

        private string ReplaceThisWithID(string text)
        {
            return text.Replace("this", ID.ToString());
        }

    }

}