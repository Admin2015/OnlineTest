using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OnlineTest.UIL.Startup))]
namespace OnlineTest.UIL
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
