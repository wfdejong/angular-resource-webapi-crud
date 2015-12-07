using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(angulartutorial.Startup))]
namespace angulartutorial
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
