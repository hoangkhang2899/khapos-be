using System.ComponentModel.DataAnnotations;

namespace KhaPOS_BE.Models;

public class ProductGetDto
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public decimal Price { get; set; }
    public int? CategoryId { get; set; }
}

public class ProductAddDto
{
    [Required(ErrorMessage = "Product name is required")]
    [StringLength(256, ErrorMessage = "Product name cannot exceed 256 characters")]
    public string Name { get; set; } = null!;
    public decimal Price { get; set; }
    public int? CategoryId { get; set; }
}