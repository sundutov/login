using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ReportingLogin.Startup))]
namespace ReportingLogin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
