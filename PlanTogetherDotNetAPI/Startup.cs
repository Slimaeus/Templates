using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PlanTogetherDotNetAPI.Startup))]
namespace PlanTogetherDotNetAPI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
