using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OpenQubit.Insurance.Web.Presentation.Startup))]
namespace OpenQubit.Insurance.Web.Presentation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
