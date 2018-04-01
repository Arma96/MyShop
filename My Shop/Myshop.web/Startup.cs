using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Myshop.web.Startup))]
namespace Myshop.web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
