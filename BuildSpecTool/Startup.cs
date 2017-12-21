using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BuildSpecTool.Startup))]
namespace BuildSpecTool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
