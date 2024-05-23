using MicroservicesECommerce.ProductApi.Models;
using Microsoft.EntityFrameworkCore;

namespace MicroservicesECommerce.ProductApi.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    { }

    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }

    // FluentAPI
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Category
        modelBuilder.Entity<Category>().HasKey(c => c.CategoryId);

        modelBuilder.Entity<Category>()
            .Property(c => c.Name)
            .HasMaxLength(100).
            IsRequired();

        // Product
        modelBuilder.Entity<Product>()
            .Property(p => p.Name)
            .HasMaxLength(100)
            .IsRequired();

        modelBuilder.Entity<Product>()
            .Property(p => p.Description)
            .HasMaxLength(255)
            .IsRequired();

        modelBuilder.Entity<Product>()
            .Property(p => p.ImageURL)
            .HasMaxLength(255)
            .IsRequired();

        modelBuilder.Entity<Product>()
            .Property(p => p.Price)
            .HasPrecision(12, 2);

        modelBuilder.Entity<Category>()
            .HasMany(g => g.Products)
            .WithOne(c => c.Category)
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);

        // Registro pré definidos
        modelBuilder.Entity<Category>()
            .HasData(
                new Category
                {
                    CategoryId = 1,
                    Name = "Eletrônicos",
                },
                new Category
                {
                    CategoryId = 2,
                    Name = "Wearables"
                }
            );
    }
}
