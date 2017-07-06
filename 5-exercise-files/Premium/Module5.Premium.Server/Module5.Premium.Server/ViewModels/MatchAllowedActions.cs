namespace Module5.Premium.Server.ViewModels
{
    public class MatchAllowedActions
    {
        public bool CanStart { get; set; }
        public bool CanEnd { get; set; }
        public bool CanStartPeriod { get; set; }
        public bool CanEndPeriod { get; set; }
        public bool CanScoreGoal { get; set; }
        public bool CanCallTimeout1 { get; set; }
        public bool CanCallTimeout2 { get; set; }
        public bool CanResume { get; set; }
        public bool CanUndo { get; set; }
    }
}