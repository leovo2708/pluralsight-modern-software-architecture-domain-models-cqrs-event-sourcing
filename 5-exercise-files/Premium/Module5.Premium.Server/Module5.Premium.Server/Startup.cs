using Microsoft.Owin;
using Module5.Premium.Server;
using Owin;

[assembly: OwinStartup(typeof(Startup))]

namespace Module5.Premium.Server
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}
