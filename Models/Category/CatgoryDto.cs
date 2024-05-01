using System.ComponentModel.DataAnnotations;

namespace KhaPOS_BE.Models;

public class CategoryGetDto
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public ICollection<ProductGetDto>? Products { get; set; }
}

public class CategoryAddDto
{
    [Required(ErrorMessage = "Category name is required")]
    [StringLength(256, ErrorMessage = "Category name cannot exceed 256 characters")]
    public string Name { get; set; } = null!;
}