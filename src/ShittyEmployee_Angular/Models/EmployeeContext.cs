
using Microsoft.Data.Entity;

namespace ShittyEmployee_Angular.Models
{
    public class EmployeeContext : DbContext
    {
        //Employee Entity for EF7
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Employee>().HasKey(m => m.Id);
            base.OnModelCreating(builder);
        }
    }
}
