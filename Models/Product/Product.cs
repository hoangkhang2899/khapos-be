using System.ComponentModel.DataAnnotations;

namespace KhaPOS_BE.Models;

public class Product
{
    public int Id { get; set; }
    [Required]
    [MaxLength(200)]
    public string Name { get; set; } = null!;
    [Required]
    public decimal Price { get; set; }
    public ICollection<Topping> Toppings { get; set; } = [];
}