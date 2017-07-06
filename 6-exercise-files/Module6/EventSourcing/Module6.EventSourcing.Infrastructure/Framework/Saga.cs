using System;
using Module6.EventSourcing.Infrastructure.Framework.EventStore;

namespace Module6.EventSourcing.Infrastructure.Framework
{
    public abstract class Saga
    {
        public IBus Bus { get; private set; }
        public IEventStore EventStore { get; private set; }


        protected Saga(IBus bus, IEventStore eventStore)
        {
            if (bus == null)
            {
                throw new ArgumentNullException("bus");
            }
            //if (eventStore == null)
            //{
            //    throw new ArgumentNullException("eventStore");
            //}

            Bus = bus;
            EventStore = eventStore;
        }
    }

}