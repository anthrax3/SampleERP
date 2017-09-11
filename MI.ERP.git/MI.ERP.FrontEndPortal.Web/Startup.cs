using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MI.ERP.FrontEndPortal.Web.Startup))]
namespace MI.ERP.FrontEndPortal.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
