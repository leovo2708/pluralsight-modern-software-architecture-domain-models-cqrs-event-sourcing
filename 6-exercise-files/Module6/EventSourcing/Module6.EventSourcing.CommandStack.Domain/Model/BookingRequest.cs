using System;
using Module6.EventSourcing.CommandStack.Domain.Common;
using Module6.EventSourcing.CommandStack.Domain.Model.Events;
using Module6.EventSourcing.SharedKernel;

namespace Module6.EventSourcing.CommandStack.Domain.Model
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
        public string Notes { get; private set; }
        public Boolean BeenProcessed { get; private set; }

        public void Apply(BookingRequestCreatedEvent evt)
        {
            CourtId = evt.CourtId;
            Hour = evt.Hour;
            Length = evt.Length;
            Name = evt.UserName;
        }

        public SlotInfo ToSlotInfo()
        {
            var slot = new SlotInfo();
            slot.CourtId = CourtId;
            slot.Length = Length;
            slot.Name = Name;
            slot.Notes = Notes;
            slot.StartingAt = Hour;
            return slot;
        }

        public static class Factory
        {
            public static BookingRequest Create(int courtId, int hour, int length, string name, string notes)
            {
                var requested = new BookingRequestCreatedEvent(courtId, hour, length, name, notes);
                var request = new BookingRequest();
                request.RaiseEvent(requested);
                return request;
            }
        }
    }
}