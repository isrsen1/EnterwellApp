using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EnterwellApp.Presentation.Startup))]
namespace EnterwellApp.Presentation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
