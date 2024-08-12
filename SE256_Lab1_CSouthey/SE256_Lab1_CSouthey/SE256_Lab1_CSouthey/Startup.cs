using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SE256_Lab1_CSouthey.Startup))]
namespace SE256_Lab1_CSouthey
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
