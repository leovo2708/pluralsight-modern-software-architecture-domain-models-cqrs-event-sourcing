using System;
using Module5.Deluxe.CommandStack.Domain.Common;
using Module5.Deluxe.CommandStack.Domain.Model.Events;

namespace Module5.Deluxe.CommandStack.Domain.Model
{
    public class BookingRequest : Aggregate
    {
        protected BookingRequest()
        {
            // Assign a unique temporary reference
            Id = Guid.NewGuid();
        }

        public int CourtId { get; private set; }
        public int Hour { get; private set; }
        public int Length { get; private set; }
        public string Name { get; private set; }
        public Boolean BeenProcessed { get; private set; }

        public void Apply(BookingRequestCreatedEvent evt)
        {
            CourtId = evt.CourtId;
            Hour = evt.Hour;
            Length = evt.Length;
            Name = evt.UserName;
        }

        public static class Factory
        {
            public static BookingRequest Create(int courtId, int hour, int length, string name)
            {
                var requested = new BookingRequestCreatedEvent(courtId, hour, length, name);
                var request = new BookingRequest();
                request.RaiseEvent(requested);
                return request;
            }
        }
    }
}