using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(W7_Assignment.Startup))]
namespace W7_Assignment
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
