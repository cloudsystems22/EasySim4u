using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EasySim4u.Startup))]
namespace EasySim4u
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
