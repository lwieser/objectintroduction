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
                    "server=localhost;port=3307;database=efdemo;uid=efdemo;password=efdemo;TreatTinyAsBoolean=false";
                optionsBuilder.UseMySql(cs);
            }
        }
    }
}
