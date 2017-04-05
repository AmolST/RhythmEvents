using Microsoft.Owin;
using Owin;
using Rhythm.Event.WebAPI;

[assembly: OwinStartup(typeof(Startup))]

namespace Rhythm.Event.WebAPI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
