using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Template.Presentation.Web.Startup))]
namespace Template.Presentation.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
