using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IdentityUsersRoles.Startup))]
namespace IdentityUsersRoles
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
