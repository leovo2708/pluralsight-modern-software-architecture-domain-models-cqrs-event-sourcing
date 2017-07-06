using System.Linq;
using Module6.EventSourcing.Infrastructure.Persistence.SqlServer;

namespace Module6.EventSourcing.QueryStack.DataAccess
{
    public interface IDatabase
    {
        IQueryable<Booking> Bookings { get; }
        IQueryable<Court> Courts { get; }
    }
}