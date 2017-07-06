using System;
using Module5.Deluxe.Infrastructure.Framework;

namespace Module5.Deluxe.CommandStack.Events
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