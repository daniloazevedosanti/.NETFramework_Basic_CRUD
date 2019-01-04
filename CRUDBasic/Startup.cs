using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CRUDBasic.Startup))]
namespace CRUDBasic
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
