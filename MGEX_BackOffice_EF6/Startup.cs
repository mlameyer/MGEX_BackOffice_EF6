using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MGEX_BackOffice_EF6.Startup))]
namespace MGEX_BackOffice_EF6
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
