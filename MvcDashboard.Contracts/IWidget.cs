using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcDashboard.Contracts
{
    /// <summary>
    /// Contract for defining a dashboard widget to retrieve html, scripts and styling required
    /// </summary>
    public interface IWidget
    {
        /// <summary>
        /// get html of widget
        /// </summary>
        /// <returns></returns>
        string GetHtml();

        /// <summary>
        /// get javascript for widget
        /// </summary>
        /// <returns></returns>
        string GetScript();

        /// <summary>
        /// get css for widget
        /// </summary>
        /// <returns></returns>
        string GetStyle();

        /// <summary>
        /// get any external script references required
        /// </summary>
        /// <returns></returns>
        List<string> GetScriptReferences();

        /// <summary>
        /// get any external style references required
        /// </summary>
        /// <returns></returns>
        List<string> GetStyleReferences();

        /// <summary>
        /// Default layout settings - optional
        /// </summary>
        /// <returns></returns>
        WidgetLayout Getlayout();

        /// <summary>
        /// Security for widget - return false to lock current user
        /// </summary>
        /// <returns></returns>
        bool HasAuthority();
        
    }
}
