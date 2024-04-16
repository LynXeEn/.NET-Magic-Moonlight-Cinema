using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Magic_Moonlight_Cinema.Startup))]
namespace Magic_Moonlight_Cinema
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
