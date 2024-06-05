using APBD8.Models;
using Microsoft.EntityFrameworkCore;

namespace APBD8.Contexts;

public class DatabaseContext : DbContext
{
    
    public DbSet<Role> Roles { get; set; }
    public DbSet<Account> Accounts { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<ProductCategory> ProductsCategories { get; set; }
    public DbSet<ShoppingCart> ShopingCarts { get; set; }
    
    protected DatabaseContext()
    {
    }

    public DatabaseContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Role>().HasData(
            new Role { Id = 1, Name = "Admin" },
            new Role { Id = 2, Name = "User" }
        );

        modelBuilder.Entity<Account>().HasData(
            new Account
            {
                Id = 1,
                RoleId = 1,
                FirstName = "John",
                LastName = "Doe",
                Email = "john.doe@example.com",
                Phone = "123456789"
            },
            new Account
            {
                Id = 2,
                RoleId = 2,
                FirstName = "Jane",
                LastName = "Doe",
                Email = "jane.doe@example.com",
                Phone = "987654321"
            }
        );

        modelBuilder.Entity<Category>().HasData(
            new Category { Id = 1, Name = "Electronics" },
            new Category { Id = 2, Name = "Books" }
        );

        modelBuilder.Entity<Product>().HasData(
            new Product
            {
                Id = 1,
                Name = "Laptop",
                Weight = 2.5m,
                Width = 35.5m,
                Height = 2.0m,
                Depth = 24.0m
            },
            new Product
            {
                Id = 2,
                Name = "Smartphone",
                Weight = 0.2m,
                Width = 7.0m,
                Height = 0.8m,
                Depth = 14.0m
            }
        );

        modelBuilder.Entity<ProductCategory>().HasData(
            new ProductCategory { ProductId = 1, CategoryId = 1 },
            new ProductCategory { ProductId = 2, CategoryId = 1 }
        );

        modelBuilder.Entity<ShoppingCart>().HasData(
            new ShoppingCart { AccountId = 1, ProductId = 1, Amount = 1 },
            new ShoppingCart { AccountId = 1, ProductId = 2, Amount = 2 },
            new ShoppingCart { AccountId = 2, ProductId = 2, Amount = 1 }
        );
    }
}