using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(vvMonza.Startup))]
namespace vvMonza
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
