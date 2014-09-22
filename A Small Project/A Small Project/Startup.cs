using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(A_Small_Project.Startup))]
namespace A_Small_Project
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
