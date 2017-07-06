using System;
using Module6.EventSourcing.Infrastructure.Framework;

namespace Module6.EventSourcing.CommandStack.Events
{
    public class BookingRequestRejectedEvent : Event
    {
        public BookingRequestRejectedEvent(Guid requestId, string reason = "")
        {
            RequestId = requestId;
            Reason = reason;
        }

        public Guid RequestId { get; private set; }
        public string Reason { get; private set; }
    }
}