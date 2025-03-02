global using Microsoft.EntityFrameworkCore;
using Demo.Models;
namespace Demo.Dbcontexts
{
    internal class Dbcontext:DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=firstRamdan;Trusted_Connection=True;TrustServerCertificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           // modelBuilder.Entity<Employee> (Builder=>
           //{
           //    Builder.HasDiscriminator<string>("Type").
           //    HasValue<FulltimeEmployee>("full").
           //    HasValue<PartTimeEmployee>("part");




           // });
        }
    }   
}
