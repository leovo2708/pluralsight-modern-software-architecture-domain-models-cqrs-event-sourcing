using System.Data.Entity;
using Module5.Regular.CommandStack.Model;

namespace Module5.Regular.CommandStack
{
    public class CommandDbContext : DbContext
    {
        public CommandDbContext()
            : base("name=MerloEntities")
        {
        }

        public virtual DbSet<Match> Matches { get; set; }
    }
}
