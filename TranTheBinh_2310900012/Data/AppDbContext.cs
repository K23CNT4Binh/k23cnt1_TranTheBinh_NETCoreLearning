using Microsoft.EntityFrameworkCore;
using TranTheBinh_2310900012.Models;

namespace TranTheBinh_2310900012.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<TtbEmployee> TtbEmployees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TtbEmployee>().ToTable("TtbEmployee");
        }
    }
}
