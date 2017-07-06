using Module5.Premium.Read.Dto;

namespace Module5.Premium.Server.ViewModels
{
    public class MatchViewModel : ViewModelBase
    {
        public MatchViewModel()
        {
            Current = new MatchInProgress();
            Actions = new MatchAllowedActions();
        }

        public MatchAllowedActions Actions { get; set; }
        public MatchInProgress Current { get; set; }
    }
}
