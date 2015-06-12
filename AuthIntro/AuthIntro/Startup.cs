using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AuthIntro.Startup))]
namespace AuthIntro
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
