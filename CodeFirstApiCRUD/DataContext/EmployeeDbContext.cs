using CodeFirstApiCRUD.Models;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstApiCRUD.DataContext
{
    public class EmployeeDbContext:DbContext
    {
        public EmployeeDbContext(DbContextOptions options):base(options)
        {
            
        }
        public DbSet<Employee> EmployeeInfo { get; set; }
    }
    
}
