using Module5.Premium.Shared;

namespace Module5.Premium.Read.Dto
{
    public class MatchInProgress
    {
        public MatchInProgress()
        {
        }

        public MatchInProgress(string id = "", string team1 = "", string team2 = "", string goal1 = "",
            string goal2 = "", string period = "", string timeoutSummary1 = "", string timeoutSummary2 = "")
        {
            Id = id;
            Team1 = team1;
            Team2 = team2;
            Goal1 = goal1;
            Goal2 = goal2;
            Period = period;
            TimeoutSummary1 = timeoutSummary1;
            TimeoutSummary2 = timeoutSummary2;
        }

        public string Id { get; set; }
        public string Team1 { get; set; }
        public string Team2 { get; set; }
        public string Goal1 { get; set; }
        public string Goal2 { get; set; }
        public string Period { get; set; }
        public MatchState State { get; set; }
        public string TimeoutSummary1 { get; set; }
        public string TimeoutSummary2 { get; set; }

        public bool IsBallInPlay
        {
            get { return State == MatchState.PlayInProgress; }
        }
    }
}