using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Jenkins_msbuild.Startup))]
namespace Jenkins_msbuild
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
