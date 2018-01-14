using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GreenGrassWebApp.Startup))]
namespace GreenGrassWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
