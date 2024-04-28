using KhaPOS_BE.Models;

using Microsoft.EntityFrameworkCore;

namespace KhaPOS_BE.Data;

public class Context : DbContext
{
    public Context(DbContextOptions options) : base(options)
    {
    }
    public DbSet<Product> Products { get; set; }
    public DbSet<Topping> Toppings { get; set; }
}