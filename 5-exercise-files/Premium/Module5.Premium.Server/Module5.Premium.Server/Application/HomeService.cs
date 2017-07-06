using Module5.Premium.Read.Facade;
using Module5.Premium.Server.ViewModels;

namespace Module5.Premium.Server.Application
{
    public class HomeService
    {
        public IndexViewModel GetIndexViewModel()
        {
            var facade = new MatchFacade();
            var model = new IndexViewModel { ScheduledMatches = facade.FindScheduled() };
            return model;
        }
    }
}