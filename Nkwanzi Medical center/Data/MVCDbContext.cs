using Microsoft.EntityFrameworkCore;
using Nkwanzi_Medical_center.Models.Domain;

namespace Nkwanzi_Medical_center.Data
{
    public class MVCDbContext : DbContext
    {
        public MVCDbContext(DbContextOptions options) : base(options)
        {
        }


        public DbSet<Employee> Employees { get; set; }
    }
}
