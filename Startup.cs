using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SuperHeroes.Startup))]
namespace SuperHeroes
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
