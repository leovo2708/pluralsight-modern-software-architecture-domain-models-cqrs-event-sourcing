using System.Linq;
using Module5.Deluxe.Infrastructure.Persistence.SqlServer.Data;

namespace Module5.Deluxe.QueryStack.DataAccess
{
    public interface IDatabase
    {
        IQueryable<Booking> Bookings { get; }
        IQueryable<Court> Courts { get; }
    }
}