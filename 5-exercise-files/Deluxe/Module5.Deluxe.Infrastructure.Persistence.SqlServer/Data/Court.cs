using System.Collections.Generic;

namespace Module5.Deluxe.Infrastructure.Persistence.SqlServer.Data
{
    public partial class Court
    {
        public Court()
        {
            this.Bookings = new HashSet<Booking>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int FirstSlot { get; set; }
        public int LastSlot { get; set; }

        public virtual ICollection<Booking> Bookings { get; set; }
    }
}
