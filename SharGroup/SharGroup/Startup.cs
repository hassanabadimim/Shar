using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SharGroup.Startup))]
namespace SharGroup
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
