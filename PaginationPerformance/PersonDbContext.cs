using Microsoft.EntityFrameworkCore;

namespace PaginationPerformance
{
    public class PersonDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseNpgsql("{connection_string}");
        }

        public DbSet<Person> Persons { get; set; }
    }
}
