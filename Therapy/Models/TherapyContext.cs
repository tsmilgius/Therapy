using Microsoft.EntityFrameworkCore;

namespace Therapy.Models
{
    public class TherapyContext: DbContext
    {
        public TherapyContext(DbContextOptions options): base(options)
        {
        }

        //public DbSet<Programme>Programme { get; set; }
        public DbSet<Bag>Solution { get; set; }
    }
}
