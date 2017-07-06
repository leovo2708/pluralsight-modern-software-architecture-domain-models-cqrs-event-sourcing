using Module5.Deluxe.Infrastructure.Framework;

namespace Module5.Deluxe.CommandStack.Events
{
    public class BookingRequestedEvent : Event
    {
        public BookingRequestedEvent(int courtId, int hour, int length, string userName)
        {
            CourtId = courtId;
            Hour = hour;
            Length = length;
            UserName = userName;
        }

        public int CourtId { get; private set; }
        public int Hour { get; private set; }
        public int Length { get; private set; }
        public string UserName { get; private set; }
    }
}