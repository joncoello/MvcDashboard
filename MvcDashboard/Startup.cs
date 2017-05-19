using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcDashboard.Startup))]
namespace MvcDashboard
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
