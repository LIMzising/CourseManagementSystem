using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TechnologyCourseSystem.Startup))]
namespace TechnologyCourseSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
