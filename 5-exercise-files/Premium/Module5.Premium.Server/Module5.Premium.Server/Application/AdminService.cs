using Module5.Premium.Command.Model;
using Module5.Premium.Infrastructure.Repositories;
using Module5.Premium.Server.Application.SignalR;
using Module5.Premium.Server.Common.Actions;

namespace Module5.Premium.Server.Application
{
    public class AdminService
    {
        public void ProcessAction(AdminAction action)
        {
            var repository = new MiscRepository();
            var matchService = new MatchService();
            switch (action)
            {
                case AdminAction.ResetDb:
                    repository.ResetDb();
                    matchService.ProcessAction("WP0001", EventType.Created, "Frogs", "Sharks");
                    matchService.ProcessAction("WP0002", EventType.Created, "Sharks", "Eels");
                    break;
            }
            LiveScoreHub.Refresh();
        }
    }
}