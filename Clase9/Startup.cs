using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Clase9.Startup))]
namespace Clase9
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
