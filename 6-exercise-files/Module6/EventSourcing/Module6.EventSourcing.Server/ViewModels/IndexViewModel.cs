using System.Collections.Generic;
using Module6.EventSourcing.QueryStack.Model;

namespace Module6.EventSourcing.Server.ViewModels
{
    public class IndexViewModel : ViewModelBase
    {
        public IList<CourtSchedule> CourtSchedules { get; set; }
    }
}