using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FristLook.Startup))]
namespace FristLook
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
