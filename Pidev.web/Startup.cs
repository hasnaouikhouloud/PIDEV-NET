using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Pidev.web.Startup))]
namespace Pidev.web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
