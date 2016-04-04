using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SendKast.Startup))]
namespace SendKast
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
