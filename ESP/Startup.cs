using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ESP.Startup))]

namespace ESP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}