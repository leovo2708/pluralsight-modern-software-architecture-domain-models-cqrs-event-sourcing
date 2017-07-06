using System.Web.Mvc;
using Module5.Deluxe.Server.Application;

namespace Module5.Deluxe.Server.Controllers
{
    public class BookingController : Controller
    {
        private readonly BookingService _service = new BookingService();

        [HttpPost]
        public ActionResult Add(int courtId, int length, int hour, string name)
        {
            _service.AddBooking(courtId, hour, length, name);
            return RedirectToAction("index", "home");
        }
    }
}