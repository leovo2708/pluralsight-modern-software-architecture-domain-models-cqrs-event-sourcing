using Module6.EventSourcing.CommandStack.Domain.Model;
using Module6.EventSourcing.Infrastructure.Persistence.SqlServer;

namespace Module6.EventSourcing.CommandStack.Domain.Services.Adapter
{
    public class Adapter 
    {
        public static Booking ToDataModel(BookingRequest entity)
        {
            var booking = new Booking
            {
                CourtId = entity.CourtId,
                Length = entity.Length,
                Name = entity.Name,
                StartingAt = entity.Hour,
                RequestId = entity.Id.ToString()
            };
            return booking;
        }
    }
}