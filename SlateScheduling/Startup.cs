using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SlateScheduling.Startup))]
namespace SlateScheduling
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
