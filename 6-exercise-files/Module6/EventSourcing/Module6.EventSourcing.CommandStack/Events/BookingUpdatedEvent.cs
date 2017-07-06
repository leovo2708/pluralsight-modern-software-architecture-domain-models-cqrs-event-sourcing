using System;
using Module6.EventSourcing.Infrastructure.Framework;
using Module6.EventSourcing.SharedKernel;

namespace Module6.EventSourcing.CommandStack.Events
{

    // Must have a public constructor and public SETTERS if you want to serialize it to JSON to event stores.
    public class BookingUpdatedEvent : Event
    {
        public BookingUpdatedEvent()
        {
        }

        public BookingUpdatedEvent(int id, int hour, string name, int length)
        {
            Id = id; 
            When = DateTime.Now;
            SagaId = id;
            Data = new SlotInfo {BookingId = id, Name = name, StartingAt = hour, Length = length};
        }

        public int Id { get; set; }
        public DateTime When { get; set; }
        public SlotInfo Data { get; set; }
    }
}