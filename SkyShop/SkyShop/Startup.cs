using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SkyShop.Startup))]
namespace SkyShop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
