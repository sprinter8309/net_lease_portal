using Microsoft.EntityFrameworkCore;
using SearchNavigator.Data.Entities;

namespace SearchNavigator.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<City> City { get; set; }
        public DbSet<Brand> Brand { get; set; }
        public DbSet<Car> Car { get; set; }
        public DbSet<Lease> Lease { get; set; }
        public DbSet<Person> Person { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=net_lease_project;Username=postgres;Password=123");           
        }
    }
}
