using Microsoft.EntityFrameworkCore;

namespace Therapy.Models
{
    public class TherapyContext: DbContext
    {
        public TherapyContext(DbContextOptions<TherapyContext> options)
            : base(options)
        {
        }

        public DbSet<TherapyEntity> TherapyEntity { get; set; }
    }
}
