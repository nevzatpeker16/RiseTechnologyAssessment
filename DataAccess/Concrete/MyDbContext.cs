using Entities.Concerate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete
{
    public class MyDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("Host=localhost;Database=postgres;Username=postgres;Password=Fatma_16");

        public MyDbContext(DbContextOptions<MyDbContext> options): base(options) { }

        public DbSet<Company> Companies { get; set; }
        public DbSet<PersonInformation> ContactInformations { get; set; }
        public DbSet<InformationType> InformationTypes { get; set; }
        public DbSet<Person> Persons { get; set; }

    }
}
