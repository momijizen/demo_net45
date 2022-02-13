using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(test_net45.Startup))]
namespace test_net45
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
