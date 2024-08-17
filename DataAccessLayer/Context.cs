using Microsoft.EntityFrameworkCore;
using Models;

namespace DataAccessLayer
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<FAQCategory>()
                .ToTable("FAQCategory")
                .HasKey(FAQCategory => FAQCategory.Id);

            modelBuilder.Entity<FAQ>()
                .ToTable("FAQ")
                .HasKey(FAQ => FAQ.Id);
            modelBuilder.Entity<FAQ>()
                .HasOne(FAQCategory => FAQCategory.FAQCategory)
                .WithMany(FAQ => FAQ.FAQs)
                .HasForeignKey(fk => fk.FAQCategoryId);

            modelBuilder.Entity<ProductCategory>()
                .ToTable("ProductCategory")
                .HasKey(ProductCategory => ProductCategory.Id);

            modelBuilder.Entity<Inventory>()
                .ToTable("Inventory")
                .HasKey(Inventory => Inventory.Id);
            modelBuilder.Entity<Inventory>()
                .HasIndex(Inventory => Inventory.ProductId)
                .IsUnique();

            modelBuilder.Entity<Product>()
                .ToTable("Product")
                .HasKey(Product => Product.Id);
            modelBuilder.Entity<Product>()
                .HasOne(ProductCategory => ProductCategory.ProductCategory)
                .WithMany(Product => Product.Products)
                .HasForeignKey(fk => fk.ProductCategoryId);
            modelBuilder.Entity<Product>()
                .HasOne(p => p.Inventory)
                .WithOne(i => i.Product)
                .HasForeignKey<Inventory>(i => i.ProductId);

            modelBuilder.Entity<Order>()
                .ToTable("Order")
                .HasKey(Order => Order.Id);

            modelBuilder.Entity<OrderItem>()
                .ToTable("OrderItem")
                .HasKey(OrderItem => OrderItem.Id);
            modelBuilder.Entity<OrderItem>()
                .HasOne(Order => Order.Order)
                .WithMany(OrderItem => OrderItem.OrderItems)
                .HasForeignKey(fk => fk.OrderId);
            // Need to add customer relation to order
        }

        public DbSet<FAQCategory> fAQCategories { get; set; }
        public DbSet<FAQ> FAQs { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
    }
}
