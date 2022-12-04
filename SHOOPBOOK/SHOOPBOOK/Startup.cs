using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SHOOPBOOK.Startup))]
namespace SHOOPBOOK
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
