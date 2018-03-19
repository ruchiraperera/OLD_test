using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC6_sample.Startup))]
namespace MVC6_sample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
