using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IMS_v1.Startup))]
namespace IMS_v1
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
