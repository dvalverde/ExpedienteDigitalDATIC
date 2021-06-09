using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ExpedienteDigital.UI.Startup))]
namespace ExpedienteDigital.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
