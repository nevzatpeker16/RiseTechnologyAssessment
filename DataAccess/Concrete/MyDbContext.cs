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
            => optionsBuilder.UseNpgsql("Host=my_host;Database=my_db;Username=my_user;Password=my_pw");



        public DbSet<Company> Companies { get; set; }
        public DbSet<ContactInformation> ContactInformations { get; set; }
        public DbSet<InformationType> InformationTypes { get; set; }
        public DbSet<Person> Persons { get; set; }

    }
}
