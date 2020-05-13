using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DevTest1.Startup))]
namespace DevTest1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
