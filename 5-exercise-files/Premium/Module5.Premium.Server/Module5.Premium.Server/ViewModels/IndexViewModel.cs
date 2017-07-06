using System.Collections.Generic;
using Module5.Premium.Read.Dto;

namespace Module5.Premium.Server.ViewModels
{
    public class IndexViewModel : ViewModelBase
    {
        public IList<MatchListItem> ScheduledMatches { get; set; }
    }
}
