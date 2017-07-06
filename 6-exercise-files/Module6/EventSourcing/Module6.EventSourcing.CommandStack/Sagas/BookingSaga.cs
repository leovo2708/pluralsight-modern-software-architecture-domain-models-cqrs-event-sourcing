using Module6.EventSourcing.CommandStack.Commands;
using Module6.EventSourcing.CommandStack.Domain.Model;
using Module6.EventSourcing.CommandStack.Events;
using Module6.EventSourcing.Infrastructure.Framework;
using Module6.EventSourcing.Infrastructure.Framework.EventStore;
using Module6.EventSourcing.Infrastructure.Framework.Repositories;
using Module6.EventSourcing.Infrastructure.Persistence.SqlServer.Repositories;

namespace Module6.EventSourcing.CommandStack.Sagas
{
    public class BookingSaga : Saga,
        IStartWithMessage<RequestBookingCommand>,
        IHandleMessage<EditBookingCommand>
    {
        private readonly IRepository _repository;

        public BookingSaga(IBus bus, IEventStore eventStore)
            : base(bus, eventStore)
        {
            _repository = new BookingRepository();
        }

        public BookingSaga(IBus bus, IEventStore eventStore, IRepository repository)
            : base(bus, eventStore)
        {
            _repository = repository;
        }

        public void Handle(RequestBookingCommand message)
        {
            var request = BookingRequest.Factory.Create(message.CourtId, message.Hour, message.Length, message.UserName,
                message.Notes);
            var response = _repository.CreateBookingFromRequest(request);
            if (!response.Success)
            {
                var rejected = new BookingRequestRejectedEvent(request.Id, response.Description);
                Bus.RaiseEvent(rejected);
                return;
            }

            var slotInfo = request.ToSlotInfo();
            var created = new BookingCreatedEvent(request.Id, response.AggregateId, slotInfo);
            Bus.RaiseEvent(created);
        }

        public void Handle(EditBookingCommand message)
        {
            var response = _repository.Update(message.BookingId, message.Hour, message.Length, message.UserName);
            if (response.Success)
            {
                var updated = new BookingUpdatedEvent(message.BookingId, message.Hour, message.UserName, message.Length);
                Bus.RaiseEvent(updated);
            }
        }
    }
}