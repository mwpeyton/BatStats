using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BatStats.Startup))]
namespace BatStats
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
