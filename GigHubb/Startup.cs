using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GigHubb.Startup))]
namespace GigHubb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
