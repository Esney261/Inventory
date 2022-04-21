using Inventory.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Inventory.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options)    
        {

        }
        public DbSet<Box> Boxes { get; set; }
        public DbSet<Location> locations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Box>().HasIndex(b => b.Name).IsUnique();
            modelBuilder.Entity<Location>().HasIndex(L => L.Rack).IsUnique();
        }


    }
}
