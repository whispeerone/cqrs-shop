using Microsoft.EntityFrameworkCore;

namespace CommandApp.Entity{
    
    public class AppDbContext : DbContext{
        public DbSet<User> Users { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Product> Products { get; set; }


        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        
       
    }
}