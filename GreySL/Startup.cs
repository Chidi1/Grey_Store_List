using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GreySL.Startup))]
namespace GreySL
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
