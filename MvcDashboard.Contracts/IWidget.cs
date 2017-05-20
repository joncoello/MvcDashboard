using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcDashboard.Contracts
{
    public interface IWidget
    {
        string GetHtml();
        string GetScript();
        string GetStyle();
        List<string> GetScriptReferences();
        List<string> GetStyleReferences();

    }
}
