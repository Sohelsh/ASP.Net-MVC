using Company_Task.Models;
using Microsoft.EntityFrameworkCore;

namespace Company_Task.Data
{
    public class AppDbContext:DbContext
    {
        //Constructor
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {

        }

        //Dbset Properties

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<State> States { get; set; }

        public DbSet<City> Cities { get; set; }
    }
}
