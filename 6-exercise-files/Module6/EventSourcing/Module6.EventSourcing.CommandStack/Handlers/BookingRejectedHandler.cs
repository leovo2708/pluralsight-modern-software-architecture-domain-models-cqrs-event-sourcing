using Module6.EventSourcing.CommandStack.Events;
using Module6.EventSourcing.Infrastructure.Framework;
using Module6.EventSourcing.Infrastructure.Framework.EventStore;

namespace Module6.EventSourcing.CommandStack.Handlers
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