using System.ComponentModel.DataAnnotations;

namespace KhaPOS_BE.Models;

public class Topping
{
    public int Id { get; set; }
    [MaxLength(200)]
    public string Name { get; set; } = string.Empty;
    public decimal Price { get; set; }

    public int? ProductId { get; set; }
    public Product? Product { get; set; }
}