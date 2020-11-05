using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Kitapcim.Startup))]
namespace Kitapcim
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
