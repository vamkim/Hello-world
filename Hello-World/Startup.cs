using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Hello_World.Startup))]
namespace Hello_World
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
