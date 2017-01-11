using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MarissaNurAini_17_XIR3_MVC.Startup))]
namespace MarissaNurAini_17_XIR3_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
