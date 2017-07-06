using Microsoft.AspNet.SignalR;

namespace Module5.Premium.Server.Application.SignalR
{
    public class LiveScoreHub : Hub
    {
        public static void Refresh()
        {
            var hubContext = GlobalHost.ConnectionManager.GetHubContext<LiveScoreHub>();
            hubContext.Clients.All.refreshPage();
        }
    }
}