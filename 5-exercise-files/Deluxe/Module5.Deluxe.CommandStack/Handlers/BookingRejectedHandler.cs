using Module5.Deluxe.CommandStack.Events;
using Module5.Deluxe.Infrastructure.Framework;
using Module5.Deluxe.Infrastructure.Framework.EventStore;

namespace Module5.Deluxe.CommandStack.Handlers
{
    public class BookingRejectedHandler : Handler,
        IHandleMessage<BookingRequestRejectedEvent>
    {
        public BookingRejectedHandler(IEventStore eventStore) 
            : base(eventStore)
        {
        }

        public void Handle(BookingRequestRejectedEvent message)
        {
            throw new System.NotImplementedException();
        }
    }
}