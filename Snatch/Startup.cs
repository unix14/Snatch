using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Snatch.Startup))]
namespace Snatch
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
