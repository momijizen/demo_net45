using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(demo_aspnet45.Startup))]
namespace demo_aspnet45
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
