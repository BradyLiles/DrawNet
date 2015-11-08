using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DrawNet.Draw.Startup))]
namespace DrawNet.Draw
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
