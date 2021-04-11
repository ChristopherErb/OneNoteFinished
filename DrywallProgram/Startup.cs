using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DrywallProgram.Startup))]
namespace DrywallProgram
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
