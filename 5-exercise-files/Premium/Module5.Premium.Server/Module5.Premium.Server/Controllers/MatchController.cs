using System;
using System.Web.Mvc;
using Module5.Premium.Command.Model;
using Module5.Premium.Server.Application;

namespace Module5.Premium.Server.Controllers
{
    public class MatchController : Controller
    {
        private readonly MatchService _matchService = new MatchService();

        public ActionResult Index(string id)
        {
            if (String.IsNullOrWhiteSpace(id))
                return RedirectToAction("index", "home");

            var model = _matchService.GetMatchDetails(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Action(string id, EventType whatHappened)
        {
            _matchService.ProcessAction(id, whatHappened);
            return RedirectToAction("index", new {id = id});
        }
    }
}