using Microsoft.EntityFrameworkCore;

namespace GroceryShopAPI.Models
{
    // AppDbContext inherits from DbContext to provide all database connection features
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // This DbSet creates a gateway to read and write rows in your Products table
        public DbSet<Product> Products { get; set; }
    }
}
