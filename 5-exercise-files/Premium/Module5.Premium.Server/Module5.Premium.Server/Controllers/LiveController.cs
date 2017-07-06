using System.Web.Mvc;
using Module5.Premium.Server.Application;

namespace Module5.Premium.Server.Controllers
{
    public class LiveController : Controller
    {
        private readonly LiveScoreService _liveScoreService = new LiveScoreService();

        public ActionResult Index()
        {
            var model = _liveScoreService.GetLiveViewModel();
            return View(model);
        }

        public PartialViewResult Update()
        {
            var model = _liveScoreService.GetLiveViewModel();
            return PartialView("_live", model);
        }
    }
}