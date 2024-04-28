using System.ComponentModel.DataAnnotations;

namespace KhaPOS_BE.Models;

public class ToppingGetDto
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public int ProductId { get; set; }
}

public class ToppingPostDto
{
    [MaxLength(200)]
    public string Name { get; set; } = string.Empty;
    public decimal Price { get; set; }
}