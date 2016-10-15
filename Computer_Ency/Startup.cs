using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Computer_Ency.Startup))]
namespace Computer_Ency
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
