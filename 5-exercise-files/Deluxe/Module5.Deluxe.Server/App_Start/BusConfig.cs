using Module5.Deluxe.CommandStack.Handlers;
using Module5.Deluxe.CommandStack.Sagas;
using Module5.Deluxe.Infrastructure.Framework;
using Module5.Deluxe.Infrastructure.Framework.EventStore;

namespace Module5.Deluxe.Server
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