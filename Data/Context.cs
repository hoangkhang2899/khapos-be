using KhaPOS_BE.Models;

using Microsoft.EntityFrameworkCore;

namespace KhaPOS_BE.Data;

public class Context : DbContext
{
    public Context(DbContextOptions options) : base(options)
    {
    }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Topping> Toppings { get; set; }
    public DbSet<Transaction> Transactions { get; set; }
    public DbSet<TransactionProduct> TransactionProducts { get; set; }
    public DbSet<TransactionProductTopping> TransactionProductToppings { get; set; }
}