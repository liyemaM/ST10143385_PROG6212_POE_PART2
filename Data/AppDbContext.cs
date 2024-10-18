using Microsoft.EntityFrameworkCore;
using PROG4.Models;

namespace PROG4.Data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        DbSet<Employee> Employees { get; set; }

        DbSet<Claim> Claims { get; set; }

        DbSet<Document> Documents { get; set; }
    }
}
