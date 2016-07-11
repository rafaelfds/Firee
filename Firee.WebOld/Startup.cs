using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Firee.Web.Startup))]
namespace Firee.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
