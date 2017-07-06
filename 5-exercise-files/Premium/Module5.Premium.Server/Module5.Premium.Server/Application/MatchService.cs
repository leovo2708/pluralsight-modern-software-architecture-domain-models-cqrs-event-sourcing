using System;
using Module5.Premium.Command;
using Module5.Premium.Command.Model;
using Module5.Premium.Read.Facade;
using Module5.Premium.Server.Application.SignalR;
using Module5.Premium.Server.ViewModels;
using Module5.Premium.Shared;
using Module5.Premium.Shared.Extensions;

namespace Module5.Premium.Server.Application
{
    public class MatchService
    {
        // Call into the read stack to read state
        public MatchViewModel GetMatchDetails(string id)
        {
            var facade = new MatchFacade();
            var model = new MatchViewModel { Current = facade.FindById(id) };

            // Handle timeouts for #1
            var canCallTimeout1 = HandleTimeoutFor(model.Current.TimeoutSummary1);
            var canCallTimeout2 = HandleTimeoutFor(model.Current.TimeoutSummary2);

            switch (model.Current.State)
            {
                case MatchState.ToBePlayed:
                    model.Actions.CanStart = true;
                    break;
                case MatchState.Warmup:
                case MatchState.Interval:
                    model.Actions.CanEnd = true;
                    model.Actions.CanStartPeriod = true;
                    model.Actions.CanUndo = true;
                    break;
                case MatchState.PlayInProgress:
                    model.Actions.CanEnd = true;
                    model.Actions.CanEndPeriod = true;
                    model.Actions.CanScoreGoal = true;
                    model.Actions.CanCallTimeout1 = canCallTimeout1;
                    model.Actions.CanCallTimeout2 = canCallTimeout2;
                    model.Actions.CanUndo = true;
                    break;
                case MatchState.Timeout:
                    model.Actions.CanEnd = true;
                    model.Actions.CanResume = true;
                    model.Actions.CanUndo = true;
                    break;
            }
            return model;
        }

        // Log the event and sync up
        public void ProcessAction(string id, EventType whatHappened, string team1 = null, string team2 = null)
        {
            switch (whatHappened)
            {
                case EventType.Undo:
                    EventSourceManager.RemoveLast(id);
                    break;
                case EventType.Created:
                    EventSourceManager.Log(id, whatHappened, TeamId.Unknown, team1, team2);
                    break;
                case EventType.Start:
                    EventSourceManager.Log(id, whatHappened);
                    break;
                case EventType.End:
                    EventSourceManager.Log(id, whatHappened);
                    break;
                case EventType.Resume:
                    EventSourceManager.Log(id, whatHappened);
                    break;
                case EventType.NewPeriod:
                    EventSourceManager.Log(id, whatHappened);
                    break;
                case EventType.EndPeriod:
                    EventSourceManager.Log(id, whatHappened);
                    break;
                case EventType.Goal1:
                    EventSourceManager.Log(id, whatHappened, TeamId.Home, GetRandomPlayerId());
                    break;
                case EventType.Goal2:
                    EventSourceManager.Log(id, whatHappened, TeamId.Visitors, GetRandomPlayerId());
                    break;
                case EventType.Timeout1:
                    EventSourceManager.Log(id, whatHappened, TeamId.Home);
                    break;
                case EventType.Timeout2:
                    EventSourceManager.Log(id, whatHappened, TeamId.Visitors);
                    break;
            }

            // Notify the live module of changes
            LiveScoreHub.Refresh();
        }

        private static int GetRandomPlayerId()
        {
            var rnd = new Random();
            return rnd.Next(2, 15);
        }

        private bool HandleTimeoutFor(string timeoutSummary)
        {
            var canCallTimeout = false;
            if (!String.IsNullOrWhiteSpace(timeoutSummary))
            {
                var tokens = timeoutSummary.Split('/');
                if (tokens.Length == 2)
                {
                    canCallTimeout = tokens[0].ToInt() < tokens[1].ToInt();
                }
            }
            return canCallTimeout;
        }
    }
}