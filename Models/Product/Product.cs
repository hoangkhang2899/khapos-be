using Microsoft.EntityFrameworkCore;

namespace KhaPOS_BE.Models;

public class Product
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public decimal Price { get; set; }
}

public class ProductContext : DbContext
{
    public ProductContext(DbContextOptions options) : base(options)
    {
    }
    public DbSet<Product> Products { get; set; } = null!;
}