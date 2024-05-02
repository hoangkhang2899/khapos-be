using System.ComponentModel.DataAnnotations;

namespace KhaPOS_BE.Models;

public class Category
{
    public int Id { get; set; }
    [MaxLength(256)]
    public string Name { get; set; } = null!;
    public ICollection<Product>? Products { get; set; }
}