using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace ObjectIntroduction
{
    public class ObjectIntroductionContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                string cs =
                    "server=host.docker.internal;port=3307;database=efdemo;uid=efdemo;password=efdemo;TreatTinyAsBoolean=false";
                optionsBuilder.UseMySql(cs);
            }
        }
    }
}
