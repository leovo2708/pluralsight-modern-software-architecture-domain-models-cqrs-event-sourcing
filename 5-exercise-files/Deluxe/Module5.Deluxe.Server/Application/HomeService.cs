using System.Collections.Generic;
using System.Linq;
using Module5.Deluxe.Infrastructure.Persistence.SqlServer.Data;
using Module5.Deluxe.QueryStack.DataAccess;
using Module5.Deluxe.QueryStack.DataAccess.Extensions;
using Module5.Deluxe.QueryStack.Model;
using Module5.Deluxe.Server.ViewModels;

namespace Module5.Deluxe.Server.Application
{
    public class HomeService
    {
        public IndexViewModel GetIndexViewModel()
        {
            var db = new Database();
            var courtSchedules = new List<CourtSchedule>();
            
            // Get booking for courts
            var courts = db.Courts.ToList();
            var courtIds = (from c in courts select c.Id).Distinct().ToArray();
            var bookings = db.Bookings.ForCourts(courtIds);

            foreach (var court in courts)
            {
                var schedule = GetScheduleForCourt(court, bookings.Where(b => b.CourtId == court.Id).ToList());
                courtSchedules.Add(schedule);
            }

            var model = new IndexViewModel();
            model.CourtSchedules = courtSchedules;
            return model;
        }

        private static CourtSchedule GetScheduleForCourt(Court court, IList<Booking> bookings)
        {
            var schedule = new CourtSchedule();
            schedule.CourtId = court.Id;
            schedule.CourtName = court.Name;

            for (var hour = court.FirstSlot; hour <= court.LastSlot; hour++)
            {
                var slot = new Slot();
                slot.StartingAt = hour;

                var matchingBooking = (from b in bookings where b.StartingAt == hour select b).FirstOrDefault();
                if (matchingBooking != null)
                {
                    slot.BookingId = matchingBooking.Id;
                    slot.Name = matchingBooking.Name;
                    slot.Length = matchingBooking.Length;
                    if (slot.Length > 1)
                        hour += (slot.Length - 1);
                }
                schedule.Slots.Add(slot);
            }
            return schedule;
        }
    }
}