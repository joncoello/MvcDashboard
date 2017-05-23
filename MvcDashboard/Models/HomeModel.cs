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

    public class HomeWidget {

        public Guid ID { get; set; }

        private string _template;
        public string Template {
            get {
                return _template;
            }
            set {
                _template = ReplaceThisWithID(value);
            }
        }

        private string _script;
        public string Script {
            get {
                return _script;
            }
            set {
                _script = ReplaceThisWithID(value);
            }
        }

        public string Style { get; set; }

        public List<string> ScriptReferences { get; set; }

        public List<string> StyleReferences { get; set; }

        public WidgetLayout Layout{ get; set; }

        public HomeWidget()
        {
            ID = Guid.NewGuid();
            ScriptReferences = new List<string>();
            StyleReferences = new List<string>();
        }

        private string ReplaceThisWithID(string text) {
            return text.Replace("this", ID.ToString());
        }

    }

}