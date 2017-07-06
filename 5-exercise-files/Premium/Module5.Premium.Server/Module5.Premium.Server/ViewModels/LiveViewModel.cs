using System.Collections.Generic;
using Module5.Premium.Read.Dto;

namespace Module5.Premium.Server.ViewModels
{
    public class LiveViewModel : ViewModelBase
    {
        public LiveViewModel()
        {
            LiveMatches = new List<MatchInProgress>();
        }

        public IList<MatchInProgress> LiveMatches { get; set; }
    }
}
