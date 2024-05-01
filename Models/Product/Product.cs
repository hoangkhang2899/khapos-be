using System.ComponentModel.DataAnnotations;

using Microsoft.EntityFrameworkCore;

namespace KhaPOS_BE.Models;

public class Product
{
    public int Id { get; set; }
    [MaxLength(256)]
    public string Name { get; set; } = null!;
    [Precision(20, 8)]
    public decimal Price { get; set; }
    public int? CategoryId { get; set; }
    public Category? Category { get; set; }
}