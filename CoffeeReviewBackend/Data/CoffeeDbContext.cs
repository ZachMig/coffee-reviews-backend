using CoffeeReviewBackend.Models;
using Microsoft.EntityFrameworkCore;

namespace CoffeeReviewBackend.Data
{
    public class CoffeeDbContext : DbContext
    {
        public CoffeeDbContext(DbContextOptions<CoffeeDbContext> options) : base(options) { }

        public DbSet<Brand> Brands { get; set; }
        public DbSet<Coffee> Coffees { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
