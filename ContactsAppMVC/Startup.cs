using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ContactsAppMVC.Startup))]
namespace ContactsAppMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
