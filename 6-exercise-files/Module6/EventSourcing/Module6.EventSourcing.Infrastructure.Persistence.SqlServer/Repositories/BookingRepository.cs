using System;
using System.Linq;
using Module6.EventSourcing.CommandStack.Domain.Common;
using Module6.EventSourcing.CommandStack.Domain.Model;
using Module6.EventSourcing.Infrastructure.Framework;
using Module6.EventSourcing.Infrastructure.Framework.Repositories;
using Module6.EventSourcing.Infrastructure.Persistence.SqlServer.Repositories.Adapters;

namespace Module6.EventSourcing.Infrastructure.Persistence.SqlServer.Repositories
{
    public class BookingRepository : IRepository
    {
        private readonly expoware_MerloEntities _merloEntities;
        public BookingRepository()
        {
            _merloEntities = new expoware_MerloEntities();
        }

        public T GetById<T>(int id) where T : IAggregate
        {
            throw new NotImplementedException();
        }

        public CommandResponse CreateBookingFromRequest<T>(T item) where T : class, IAggregate
        {
            // Gets a BookingRequest
            var request = item as BookingRequest;
            var booking = Adapter.RequestToBooking(request);
            
            _merloEntities.Bookings.Add(booking); //.Set<T>().Add(booking);
            var count = _merloEntities.SaveChanges();

            var response = new CommandResponse(count >0, booking.Id) {RequestId = new Guid(booking.RequestId)};
            return response;
        }

        public CommandResponse Update(int bookingId, int hour, int length, string name)
        {
            //var current = DateTime.Now;
            //if (current.Second % 2 == 0)
            //{
            //    return CommandResponse.Fail;
            //}

            var booking = (from b in _merloEntities.Bookings where b.Id == bookingId select b).FirstOrDefault();
            if (booking == null)
                return CommandResponse.Fail;

            booking.Id = bookingId;
            booking.StartingAt = hour;
            booking.Length = length;
            booking.Name = name;
            var count = _merloEntities.SaveChanges();
            var response = new CommandResponse(count > 0, booking.Id);
            return response;
        }
    }
}