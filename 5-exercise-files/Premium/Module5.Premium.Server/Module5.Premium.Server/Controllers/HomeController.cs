using System.Web.Mvc;
using Module5.Premium.Server.Application;

namespace Module5.Premium.Server.Controllers
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