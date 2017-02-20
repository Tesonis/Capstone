using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ShowList.Startup))]
namespace ShowList
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
