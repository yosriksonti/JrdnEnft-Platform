using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PIkindergarten.Startup))]
namespace PIkindergarten
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
