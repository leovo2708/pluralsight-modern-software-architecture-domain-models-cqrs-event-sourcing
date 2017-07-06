using System.Web.Mvc;
using Module6.EventSourcing.Server.Application;

namespace Module6.EventSourcing.Server.Controllers
{
    public class BookingController : Controller
    {
        private readonly BookingService _service = new BookingService();

        [HttpPost]
        public ActionResult Add(int courtId, int length, int hour, string name, string notes)
        {
            _service.AddBooking(courtId, hour, length, name, notes);
            return RedirectToAction("index", "home");
        }

        [HttpPost]
        public ActionResult Edit(int id, int hour, string name, int length)
        {
            _service.EditBooking(id, hour, name, length);
            return RedirectToAction("index", "home");
        }
    }
}