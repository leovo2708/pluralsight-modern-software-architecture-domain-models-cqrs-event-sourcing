using Module5.Deluxe.CommandStack.Domain.Common;

namespace Module5.Deluxe.CommandStack.Domain.Model.Events
{
    public class BookingRequestCreatedEvent : DomainEvent
    {
        public BookingRequestCreatedEvent(int courtId, int hour, int length, string userName)
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