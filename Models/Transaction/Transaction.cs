using System.ComponentModel.DataAnnotations;

using Microsoft.EntityFrameworkCore;

namespace KhaPOS_BE.Models;

public class Transaction
{
    public int Id { get; set; }
    public decimal TotalPrice { get; set; }
    public DateTime CreatedAt { get; set; }
    public ICollection<TransactionProduct> Products { get; set; } = [];
}

public class TransactionProduct
{
    public int Id { get; set; }
    public int Quantity { get; set; }

    public int? ProductId { get; set; }
    public Product? Product { get; set; }
    public ICollection<TransactionProductTopping> Toppings { get; set; } = [];
}

public class TransactionProductTopping
{
    public int Id { get; set; }
    public int Quantity { get; set; }

    public int? ToppingId { get; set; }
    public Topping? Topping { get; set; }
    public int TransactionProductId { get; set; }
}