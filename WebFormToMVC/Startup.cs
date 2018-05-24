using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebFormToMVC.Startup))]
namespace WebFormToMVC
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
