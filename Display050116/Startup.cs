using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Display050116.Startup))]
namespace Display050116
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
