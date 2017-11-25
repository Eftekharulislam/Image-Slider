using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SlideShow.Startup))]
namespace SlideShow
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
