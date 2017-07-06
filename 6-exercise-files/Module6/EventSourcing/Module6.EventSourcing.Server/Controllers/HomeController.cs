using System.Web.Mvc;
using Module6.EventSourcing.Server.Application;

namespace Module6.EventSourcing.Server.Controllers
{
    public class HomeController : Controller
    {
        private readonly HomeService _homeService = new HomeService();

        public ActionResult Index()
        {
            var model = _homeService.GetIndexViewModel();
            return View(model);
        }
    }
}