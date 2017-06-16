using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TheMachineACafe.Startup))]
namespace TheMachineACafe
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
