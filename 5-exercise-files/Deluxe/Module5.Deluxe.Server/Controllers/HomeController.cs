using System.Web.Mvc;
using Module5.Deluxe.Server.Application;

namespace Module5.Deluxe.Server.Controllers
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