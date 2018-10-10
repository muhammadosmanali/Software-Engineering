using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Contact_Manage.Startup))]
namespace Contact_Manage
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
