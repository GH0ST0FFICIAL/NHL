using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NHL.Startup))]
namespace NHL
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
