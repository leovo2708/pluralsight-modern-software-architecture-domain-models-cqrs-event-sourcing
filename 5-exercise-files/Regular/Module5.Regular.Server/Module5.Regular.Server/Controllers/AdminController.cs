using System.Web.Mvc;
using Module5.Regular.Server.ApplicationLayer;
using Module5.Regular.Server.ApplicationLayer.Abstractions;
using Module5.Regular.Server.Models;

namespace Module5.Regular.Server.Controllers
{
    public class AdminController : Controller
    {
        private readonly IAdminService _adminService; 

        public AdminController() : this(new AdminService())
        {
        }
        public AdminController(IAdminService service)
        {
            _adminService = service;
        }

        [HttpGet]
        [ActionName("Register")]
        public ActionResult DisplayRegister()
        {
            // Perform the query
            var model = _adminService.GetAdminViewModel();
            return View(model);
        }

        [HttpPost]
        [ActionName("Register")]
        public ActionResult PostRegister(RegisterInputModel input)
        {
            // Perform the command
            _adminService.Register(input);

            // Re-routes
            return RedirectToAction("register");
        }
    }
}