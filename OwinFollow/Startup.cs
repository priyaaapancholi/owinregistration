using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OwinFollow.Startup))]
namespace OwinFollow
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
