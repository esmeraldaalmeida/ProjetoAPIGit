using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjetoAPIGit.Startup))]
namespace ProjetoAPIGit
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
