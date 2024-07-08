using Microsoft.EntityFrameworkCore;
using OrderMonitorService.Models;

namespace OrderMonitorService.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
    }
}