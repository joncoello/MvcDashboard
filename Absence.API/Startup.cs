using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Absence.API
{
    public class Startup
    {
        public void Configuration(IAppBuilder app) {
            
            var config = new HttpConfiguration();

            // routing
            config.MapHttpAttributeRoutes();

            // cors
            var cors = new EnableCorsAttribute("*", "*", "*");
            config.EnableCors(cors);

            app.UseWebApi(config);

        }
    }
}