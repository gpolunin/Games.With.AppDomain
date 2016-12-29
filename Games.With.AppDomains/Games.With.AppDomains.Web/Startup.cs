using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Games.With.AppDomains.Web.Startup))]
namespace Games.With.AppDomains.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
