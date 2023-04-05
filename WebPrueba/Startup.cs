using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebPrueba.Startup))]
namespace WebPrueba
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
