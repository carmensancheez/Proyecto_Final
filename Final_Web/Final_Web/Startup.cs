using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Final_Web.Startup))]
namespace Final_Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
