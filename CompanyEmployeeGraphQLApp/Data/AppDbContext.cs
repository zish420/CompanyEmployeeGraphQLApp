using CompanyEmployeeGraphQLApp.Models;
using Microsoft.EntityFrameworkCore;

namespace CompanyEmployeeGraphQLApp.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Company> Companies { get; set; }
        public DbSet<Employee> Employees { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    }
}
