using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lesson1_WebCalc_CS.Startup))]
namespace Lesson1_WebCalc_CS
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
