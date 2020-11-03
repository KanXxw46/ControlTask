using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControlWork_StarWors_
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext()
        {
            Database.Migrate();
        }

        public DbSet<people> Categories { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = (localdb)\\mssqllocaldb; Database = ControlWork_StarWors_; Trusted_Connection = true;")
                .UseLazyLoadingProxies();
        }
    }
}
