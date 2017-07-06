using System;
using Module5.Deluxe.Infrastructure.Framework.EventStore;

namespace Module5.Deluxe.Infrastructure.Framework
{
    public abstract class Handler
    {
        public IEventStore EventStore { get; private set; }


        public Handler(IEventStore eventStore)
        {
            if (eventStore == null)
            {
                throw new ArgumentNullException("eventStore");
            }

            EventStore = eventStore;
        }
    }

}