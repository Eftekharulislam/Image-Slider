using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ImageSlider.Startup))]
namespace ImageSlider
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
