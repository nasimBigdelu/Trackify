using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Trackify.Startup))]
namespace Trackify
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
