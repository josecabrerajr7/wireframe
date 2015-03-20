using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(wireframe.Startup))]
namespace wireframe
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
