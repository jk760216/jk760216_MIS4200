using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(jk760216_MIS4200.Startup))]
namespace jk760216_MIS4200
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
