using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebApp4.Startup))]
namespace WebApp4
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            string a = "3";
            ConfigureAuth(app);
        }
    }
}
