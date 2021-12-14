using Microsoft.EntityFrameworkCore;
using Wpf_core_test.Models;



namespace Wpf_core_test
{
   public class ApplicationContext : DbContext 
    {
     
            public DbSet<Agreement> Agreements { get; set; }
            public DbSet<Person> Persons { get; set; }
            public DbSet<StatusAggrement> StatusAggrements { get; set; }
            public DbSet<TypeAggrement> TypeAggrements { get; set; }



            public ApplicationContext()
            {
                Database.EnsureDeleted();
                Database.EnsureCreated();
            }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb; " +
            "Database=agreementdb; Trusted_Connection=True;");
        }  
        
    }
}
