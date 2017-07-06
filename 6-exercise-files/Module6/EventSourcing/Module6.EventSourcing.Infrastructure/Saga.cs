using System;

namespace Merlo.Eda.Infrastructure
{
    public abstract class Saga
    {
        public IBus Bus { get; private set; }
        public IEventStore EventStore { get; private set; }


        public Saga(IBus bus, IEventStore eventStore)
        {
            if (bus == null)
            {
                throw new ArgumentNullException("bus");
            }
            if (eventStore == null)
            {
                throw new ArgumentNullException("eventStore");
            }

            Bus = bus;
            EventStore = eventStore;
        }
    }

}