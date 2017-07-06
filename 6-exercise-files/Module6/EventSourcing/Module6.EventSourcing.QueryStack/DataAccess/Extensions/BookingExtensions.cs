using System.Linq;
using Module6.EventSourcing.Infrastructure.Persistence.SqlServer;

namespace Module6.EventSourcing.QueryStack.DataAccess.Extensions 
{
    public static class BookingExtensions
    {
        public static IQueryable<Booking> ForCourts(this IQueryable<Booking> bookings, params int[] courtIds)
        {
            return bookings.Where(b => courtIds.Contains(b.CourtId));
        }
    }
}