using Microsoft.EntityFrameworkCore;
using Models.Entidades;

namespace Data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Brand> Brands { get; set; }


        // si el modelo no se llama igual que la tabla usamos on modelcreating
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Brand>().ToTable("Brands");
        }
    }
}
