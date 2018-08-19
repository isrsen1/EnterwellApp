using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EnterwellApp.Startup))]
namespace EnterwellApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
