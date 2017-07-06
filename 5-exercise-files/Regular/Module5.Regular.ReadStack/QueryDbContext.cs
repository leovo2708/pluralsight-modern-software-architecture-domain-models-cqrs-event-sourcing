using System.Data.Entity;
using Module5.Regular.ReadStack.Model;

namespace Module5.Regular.ReadStack
{
    class QueryDbContext : DbContext
    {
        public QueryDbContext()
            : base("name=MerloEntities")
        {
        }

        public virtual DbSet<Match> Matches { get; set; }
    }
}
