using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Templates.AspNetFramework.Startup))]
namespace Templates.AspNetFramework
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
