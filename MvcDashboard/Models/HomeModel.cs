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

        public HomeWidget()
        {
            ID = Guid.NewGuid();
        }

        private string ReplaceThisWithID(string text) {
            return text.Replace("\"this\"", "\"" + ID.ToString() + "\"");
        }

    }

}