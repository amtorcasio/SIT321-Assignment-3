using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SIT321_Assignment_3.Startup))]
namespace SIT321_Assignment_3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);

            // i farted and it smells
        }
    }
}
