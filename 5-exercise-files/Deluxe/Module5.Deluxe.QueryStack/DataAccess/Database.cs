using System.Linq;
using Module5.Deluxe.Infrastructure.Persistence.SqlServer.Data;

namespace Module5.Deluxe.QueryStack.DataAccess
{
    public class Database : IDatabase
    {
        private readonly MerloEntities _merlo;
        public Database()
        {
            _merlo = new MerloEntities();
        }

        public IQueryable<Booking> Bookings
        {
            get
            {
                return _merlo.Bookings; 
            }
        }

        public IQueryable<Court> Courts
        {
            get
            {
                return _merlo.Courts;
            }
        }
    }
}