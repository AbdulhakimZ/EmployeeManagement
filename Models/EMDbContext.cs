using EmployeeManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Models
{
    public class EMDbContext : DbContext
    {
        public EMDbContext(DbContextOptions<EMDbContext> options) : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
    }
}
