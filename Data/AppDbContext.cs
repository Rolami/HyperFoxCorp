using HyperFoxCorp.Models;
using Microsoft.EntityFrameworkCore;

namespace HyperFoxCorp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<LeaveApplication> LeaveApplications { get; set; }

    }
}
