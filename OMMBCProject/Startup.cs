using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OMMBCProject.Startup))]
namespace OMMBCProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
