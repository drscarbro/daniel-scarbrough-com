using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DanielScarbrough.Startup))]
namespace DanielScarbrough
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
