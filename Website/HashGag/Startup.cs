using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HashGag.Startup))]
namespace HashGag
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
