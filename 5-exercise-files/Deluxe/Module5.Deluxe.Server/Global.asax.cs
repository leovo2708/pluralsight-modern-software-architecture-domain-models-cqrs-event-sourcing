using System.Web;
using System.Web.Routing;
using Module5.Deluxe.Infrastructure.Framework;

namespace Module5.Deluxe.Server
{
    public class BookingApplication : HttpApplication
    {
        public static IBus Bus { get; set; }

        protected void Application_Start()
        {
            BusConfig.Initialize();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
