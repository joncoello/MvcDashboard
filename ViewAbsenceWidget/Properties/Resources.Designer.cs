﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ViewAbsenceWidget.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ViewAbsenceWidget.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;!DOCTYPE html&gt;
        ///&lt;html&gt;
        ///&lt;head&gt;
        ///    &lt;title&gt;&lt;/title&gt;
        ///    &lt;meta charset=&quot;utf-8&quot; /&gt;
        ///
        ///    &lt;link href=&quot;https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css&quot; rel=&quot;stylesheet&quot; /&gt;
        ///    &lt;link href=&quot;style.css&quot; rel=&quot;stylesheet&quot; /&gt;
        ///
        ///&lt;/head&gt;
        ///&lt;body&gt;
        ///
        ///    &lt;div style=&quot;width: 600px;&quot;&gt;
        ///
        ///        &lt;!--bodystart--&gt;
        ///        &lt;div id=&quot;this&quot; class=&quot;holiday-widget&quot;&gt;&lt;/div&gt;
        ///        &lt;!--bodyend--&gt;
        ///
        ///    &lt;/div&gt;
        ///
        ///    &lt;button id=&quot;refreshHolidayButton&quot;&gt;refresh&lt;/button&gt;
        ///
        ///    &lt;script src=&quot;https://code.jquery [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string index {
            get {
                return ResourceManager.GetString("index", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to var widgetElement1 = document.getElementById(&apos;this&apos;);
        ///var widget1 = new WidgetComponenet(widgetElement1, {
        ///    loadData: getHolidayData
        ///});
        ///function getHolidayData(e) {
        ///    $.get(&apos;http://localhost:1187/api/holiday&apos;, function (data) {
        ///        console.log(e);
        ///        $(e).empty();
        ///        console.log(data);
        ///        var year = 2017;
        ///        var days = [
        ///            &apos;M&apos;, &apos;T&apos;, &apos;W&apos;, &apos;T&apos;, &apos;F&apos;, &apos;S&apos;, &apos;S&apos;
        ///        ];
        ///        var months = [
        ///            &apos;January&apos;, &apos;February&apos;, &apos;March&apos;, &apos;April&apos;, &apos;May&apos;, &apos;June [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string main {
            get {
                return ResourceManager.GetString("main", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to .holiday-widget {
        ///    font-size: 0.7em;
        ///}
        ///
        ///.holiday-widget &gt; .table &gt; tbody &gt; tr &gt; td, .table &gt; tbody &gt; tr &gt; th,
        ///.holiday-widget &gt; .table &gt; tfoot &gt; tr &gt; td, .table &gt; tfoot &gt; tr &gt; th, 
        ///.holiday-widget &gt; .table &gt; thead &gt; tr &gt; td, .table &gt; thead &gt; tr &gt; th {
        ///    padding: 2px;
        ///    text-align: center;
        ///}
        ///
        ///.weekend {
        ///    background-color: gray;
        ///}
        ///
        ///.nonday {
        ///    background-color: lightgray;
        ///}
        ///
        ///.holiday {
        ///    background-color: paleturquoise;
        ///}
        ///
        ///.daycol {
        ///    min-width: 20px;
        ///}
        ///.
        /// </summary>
        internal static string style {
            get {
                return ResourceManager.GetString("style", resourceCulture);
            }
        }
    }
}
