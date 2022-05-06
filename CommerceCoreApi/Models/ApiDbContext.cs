using Microsoft.EntityFrameworkCore;

namespace CommerceCoreApi.Models
{
    public class ApiDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-3CQ3GHD;Initial Catalog=ECommerceDB;Integrated Security=True"); 
        }

        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<ProductAttributes> ProductAttributes { get; set; } = null!;
        public DbSet<ProductReview> ProductReviews { get; set; } = null!;

        public DbSet<ProductCategory> ProductCategories { get; set; } = null!;
        public DbSet<Customer> Customers { get; set; } = null!;
        public DbSet<Vendor> Vendors { get; set; } = null!;

        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Cart> Carts { get; set; } = null!;
        public DbSet<Order> Orders { get; set; } = null!;
        public DbSet<Transaction> Transactions { get; set; } = null!;
        public DbSet<Wishlist> Wishlists { get; set; } = null!;


    }
}
