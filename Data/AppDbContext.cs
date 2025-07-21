
using Microsoft.EntityFrameworkCore;
using Models;

namespace Data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<BrandModel> Brands { get; set; }
        public DbSet<BeersModel> Beers { get; set; }

        // si el modelo no se llama igual que la tabla usamos on modelcreating
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BrandModel>().ToTable("Brands");
            modelBuilder.Entity<BeersModel>().ToTable("Beers");
        }
    }
}
