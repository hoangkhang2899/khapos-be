using System.ComponentModel.DataAnnotations;

using Microsoft.EntityFrameworkCore;

namespace KhaPOS_BE.Models;

public class Topping
{
    public int Id { get; set; }
    [MaxLength(256)]
    public string Name { get; set; } = string.Empty;
    [Precision(20, 8)]
    public decimal Price { get; set; }
}