using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Unity.Startup))]
namespace Unity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
