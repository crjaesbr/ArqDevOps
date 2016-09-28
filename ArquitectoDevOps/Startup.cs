using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ArquitectoDevOps.Startup))]
namespace ArquitectoDevOps
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
