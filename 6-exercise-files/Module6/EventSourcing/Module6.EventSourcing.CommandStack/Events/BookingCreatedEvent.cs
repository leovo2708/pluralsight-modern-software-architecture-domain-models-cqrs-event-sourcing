using System;
using Module6.EventSourcing.Infrastructure.Framework;
using Module6.EventSourcing.SharedKernel;

namespace Module6.EventSourcing.CommandStack.Events
{
    public class BookingCreatedEvent : Event
    {
        public BookingCreatedEvent()
        {
        }

        public BookingCreatedEvent(Guid requestId, int id, SlotInfo slotInfo)
        {
            RequestId = requestId;
            Id = id;
            When = DateTime.Now;
            Data = slotInfo;
            SagaId = id;
        }

        public int Id { get; set; }
        public Guid RequestId { get; set; }
        public DateTime When { get; set; }
        public SlotInfo Data { get; set; }
    }
}