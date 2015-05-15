using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NathanWebsiteCurrent.Startup))]
namespace NathanWebsiteCurrent
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
