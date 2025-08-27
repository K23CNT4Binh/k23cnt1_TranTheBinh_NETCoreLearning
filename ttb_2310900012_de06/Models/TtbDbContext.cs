using Microsoft.EntityFrameworkCore;

namespace ttb_2310900012_de06.Models
{
    public class TtbDbContext : DbContext
    {
        public TtbDbContext(DbContextOptions<TtbDbContext> options)
            : base(options)
        {
        }

        public DbSet<TtbStudent> TtbStudents { get; set; } = null!;
    }
}
