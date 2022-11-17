using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Flight_Doc_System.Startup))]
namespace Flight_Doc_System
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
