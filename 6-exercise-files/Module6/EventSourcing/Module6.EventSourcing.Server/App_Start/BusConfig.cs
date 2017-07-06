using Module6.EventSourcing.CommandStack.Handlers;
using Module6.EventSourcing.CommandStack.Sagas;
using Module6.EventSourcing.Infrastructure.Framework;
using Module6.EventSourcing.Infrastructure.Framework.EventStore;

namespace Module6.EventSourcing.Server
{
    public class BusConfig
    {
        public static void Initialize()
        {
            BookingApplication.Bus = new InMemoryBus(new SqlEventStore());

            BookingApplication.Bus.RegisterSaga<BookingSaga>();
            BookingApplication.Bus.RegisterHandler<BookingRejectedHandler>();
            BookingApplication.Bus.RegisterHandler<EmailHandler>();
        }
    }
}