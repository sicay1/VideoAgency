using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VideoAgency.Startup))]
namespace VideoAgency
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
