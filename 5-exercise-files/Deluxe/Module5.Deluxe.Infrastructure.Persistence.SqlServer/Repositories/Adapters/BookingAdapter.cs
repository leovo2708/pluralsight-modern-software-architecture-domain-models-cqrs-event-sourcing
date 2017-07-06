using Module5.Deluxe.CommandStack.Domain.Model;

using Module5.Deluxe.Infrastructure.Persistence.SqlServer.Data;

namespace Module5.Deluxe.Infrastructure.Persistence.SqlServer.Repositories.Adapters
{
    public class Adapter 
    {
        public static Booking RequestToBooking(BookingRequest entity)
        {
            var booking = new Booking
            {
                CourtId = entity.CourtId,
                Length = entity.Length,
                Name = entity.Name,
                StartingAt = entity.Hour,
                RequestId = entity.Id.ToString(),
            };
            return booking;
        }
    }
}