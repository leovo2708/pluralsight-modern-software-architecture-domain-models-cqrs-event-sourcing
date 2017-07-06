using System.Web.Mvc;
using Module5.Premium.Server.Application;
using Module5.Premium.Server.Common.Actions;
using Module5.Premium.Server.ViewModels;

namespace Module5.Premium.Server.Controllers
{
    public class AdminController : Controller
    {
        private readonly AdminService _adminService = new AdminService();

        public ActionResult Index()
        {
            var model = new ViewModelBase();
            return View(model);
        }

        [HttpPost]
        public ActionResult Action(AdminAction action)
        {
            _adminService.ProcessAction(action);
            return RedirectToAction("index", "home");
        }
    }
}