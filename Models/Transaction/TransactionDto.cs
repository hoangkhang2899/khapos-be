using System.ComponentModel.DataAnnotations;

using Microsoft.EntityFrameworkCore;

namespace KhaPOS_BE.Models;

public class TransactionAddDto
{
    public int Id { get; set; }
    public decimal TotalPrice { get; set; }
    public ICollection<TransactionProductAddDto> Products { get; set; } = [];
}

public class TransactionProductAddDto
{
    public int Id { get; set; }
    public int Quantity { get; set; }

    public int? ProductId { get; set; }
    public ICollection<TransactionProductToppingAddDto> Toppings { get; set; } = [];
}

public class TransactionProductToppingAddDto
{
    public int Id { get; set; }
    public int Quantity { get; set; }

    public int? ToppingId { get; set; }
}