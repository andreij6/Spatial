using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Spatial.Web.Startup))]
namespace Spatial.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
