using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(truYumOnline.Startup))]
namespace truYumOnline
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
