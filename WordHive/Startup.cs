using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WordHive.Startup))]
namespace WordHive
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
