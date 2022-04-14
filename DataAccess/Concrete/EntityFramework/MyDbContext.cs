using Entities.Concerate;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class MyDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("Host=localhost;Database=postgres;Username=postgres;Password=Fatma_16");

        public DbSet<Company> Companies { get; set; }
        public DbSet<PersonInformation> PersonInformation { get; set; }
        public DbSet<InformationType> InformationTypes { get; set; }
        public DbSet<Person> Persons { get; set; }

    }
}
