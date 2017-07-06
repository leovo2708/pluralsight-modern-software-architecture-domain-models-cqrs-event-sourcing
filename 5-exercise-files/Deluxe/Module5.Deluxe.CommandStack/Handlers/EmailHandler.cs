using System;
using Module5.Deluxe.CommandStack.Events;
using Module5.Deluxe.Infrastructure.Extras;
using Module5.Deluxe.Infrastructure.Framework;
using Module5.Deluxe.Infrastructure.Framework.EventStore;

namespace Module5.Deluxe.CommandStack.Handlers
{
    public class EmailHandler : Handler,
        IHandleMessage<BookingRequestRejectedEvent>,
        IHandleMessage<BookingCreatedEvent> 
    {
        public EmailHandler(IEventStore eventStore) 
            : base(eventStore)
        {
        }

        public void Handle(BookingRequestRejectedEvent message)
        {
            var body = String.Format("Your request {0} could not be satisfied.",
                message.RequestId);
            EmailService.Send("user@company.com", body);
        }

        public void Handle(BookingCreatedEvent message)
        {
            var body = String.Format("Congratulations! Your booking is confirmed. Your confirmation number is {0}.",
                message.Id);
            EmailService.Send("user@company.com", body);
        }
    }
}