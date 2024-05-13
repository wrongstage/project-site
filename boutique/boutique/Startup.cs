using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(boutique.Startup))]
namespace boutique
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
