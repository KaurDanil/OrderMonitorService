// using Microsoft.EntityFrameworkCore;
// using OrderMonitorService.Models; // Добавьте эту директиву using

// namespace OrderMonitorService.Data
// {
//     public class ApplicationDbContext : DbContext
//     {
//         public DbSet<Order> Orders { get; set; }
//         public DbSet<OrderItem> OrderItems { get; set; }
//         public DbSet<User> Users { get; set; }

//         protected override void OnModelCreating(ModelBuilder modelBuilder)
//         {
//             modelBuilder.Entity<Order>()
//                 .HasMany(o => o.OrderItems)
//                 .WithOne(oi => oi.Order)
//                 .HasForeignKey(oi => oi.OrderId);

//             modelBuilder.Entity<User>()
//                 .HasMany(u => u.Orders)
//                 .WithOne()
//                 .HasForeignKey("UserId");
//         }

//         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//         {
//             optionsBuilder.UseNpgsql("your_connection_string");
//         }
//     }
// }

using Microsoft.EntityFrameworkCore;
using OrderMonitorService.Models;

namespace OrderMonitorService.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>()
                .HasMany(o => o.OrderItems)
                .WithOne(oi => oi.Order)
                .HasForeignKey(oi => oi.OrderId);

            modelBuilder.Entity<User>()
                .HasMany(u => u.Orders)
                .WithOne()
                .HasForeignKey("UserId");
        }
    }
}