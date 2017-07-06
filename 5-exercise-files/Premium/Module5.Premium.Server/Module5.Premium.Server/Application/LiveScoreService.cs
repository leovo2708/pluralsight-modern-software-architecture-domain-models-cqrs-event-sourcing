using Module5.Premium.Read.Facade;
using Module5.Premium.Server.ViewModels;

namespace Module5.Premium.Server.Application
{
    public class LiveScoreService
    {
        public LiveViewModel GetLiveViewModel()
        {
            var facade = new MatchFacade();
            var model = new LiveViewModel { LiveMatches = facade.FindInProgress() };
            return model;
        }
    }
}