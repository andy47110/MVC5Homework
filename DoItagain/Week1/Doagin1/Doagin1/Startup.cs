using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Doagin1.Startup))]
namespace Doagin1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
