using Ecommerce_System.Entities;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce_System.Data;

public class ECommerceContext : DbContext
{
    public ECommerceContext
        (DbContextOptions<ECommerceContext> options) : base(options) {}
    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<OrderDetail> OrderDetails { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Customer> Customers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ECommerceContext).Assembly);
        base.OnModelCreating(modelBuilder);
    }
}