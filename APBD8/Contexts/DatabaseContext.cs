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
    public DbSet<ShopingCart> ShopingCarts { get; set; }
    
    protected DatabaseContext()
    {
    }

    public DatabaseContext(DbContextOptions options) : base(options)
    {
    }
}