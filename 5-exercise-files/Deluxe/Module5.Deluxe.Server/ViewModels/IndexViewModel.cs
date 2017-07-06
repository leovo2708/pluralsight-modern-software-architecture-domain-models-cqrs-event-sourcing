using System.Collections.Generic;
using Module5.Deluxe.QueryStack.Model;

namespace Module5.Deluxe.Server.ViewModels
{
    public class IndexViewModel : ViewModelBase
    {
        public IList<CourtSchedule> CourtSchedules { get; set; }
    }
}