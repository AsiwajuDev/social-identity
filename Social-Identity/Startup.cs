using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Social_Identity.Startup))]
namespace Social_Identity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
