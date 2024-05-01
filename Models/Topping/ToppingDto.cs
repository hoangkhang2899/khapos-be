using System.ComponentModel.DataAnnotations;

namespace KhaPOS_BE.Models;

public class ToppingGetDto
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public decimal Price { get; set; }
    public int ProductId { get; set; }
}

public class ToppingAddDto
{
    [Required(ErrorMessage = "Topping name is required")]
    [StringLength(256, ErrorMessage = "Topping name cannot exceed 256 characters")]
    public string Name { get; set; } = null!;
    public decimal Price { get; set; }
}