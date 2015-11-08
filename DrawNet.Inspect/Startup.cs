using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DrawNet.Inspect.Startup))]
namespace DrawNet.Inspect
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
