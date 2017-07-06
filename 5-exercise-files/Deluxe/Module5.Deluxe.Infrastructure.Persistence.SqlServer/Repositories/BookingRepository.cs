using System;
using Module5.Deluxe.CommandStack.Domain.Common;
using Module5.Deluxe.CommandStack.Domain.Model;
using Module5.Deluxe.Infrastructure.Framework;
using Module5.Deluxe.Infrastructure.Framework.Repositories;
using Module5.Deluxe.Infrastructure.Persistence.SqlServer.Data;
using Module5.Deluxe.Infrastructure.Persistence.SqlServer.Repositories.Adapters;

namespace Module5.Deluxe.Infrastructure.Persistence.SqlServer.Repositories
{
    public class BookingRepository : IRepository
    {
        private readonly MerloEntities _merloEntities;
        public BookingRepository()
        {
            _merloEntities = new MerloEntities();
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
    }
}