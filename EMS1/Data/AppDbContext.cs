using EMS1.Models;
using Microsoft.EntityFrameworkCore;

namespace EMS1.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        
         public DbSet<Employee> Employees { get; set; }
         public DbSet<Country> Countries { get; set; }
         public DbSet<State> States { get; set; }
        public DbSet<District> Districts { get; set; }


    }
}
