using Module6.EventSourcing.CommandStack.Domain.Common;

namespace Module6.EventSourcing.CommandStack.Domain.Model.Events
{
    public class BookingRequestCreatedEvent : DomainEvent
    {
        public BookingRequestCreatedEvent(int courtId, int hour, int length, string userName, string notes)
        {
            CourtId = courtId;
            Hour = hour;
            Length = length;
            UserName = userName;
            Notes = notes;
        }

        public int CourtId { get; private set; }
        public int Hour { get; private set; }
        public int Length { get; private set; }
        public string UserName { get; private set; }
        public string Notes { get; private set; }
    }
}