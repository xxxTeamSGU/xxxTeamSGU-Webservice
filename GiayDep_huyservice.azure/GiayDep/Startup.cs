using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GiayDep.Startup))]
namespace GiayDep
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
