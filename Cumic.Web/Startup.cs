using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Cumic.Web.Startup))]
namespace Cumic.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
