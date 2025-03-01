global using Microsoft.EntityFrameworkCore;
namespace Demo.Dbcontexts
{
    internal class Dbcontext:DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer();
        }
    }   
}
