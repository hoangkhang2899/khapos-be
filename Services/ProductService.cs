using KhaPOS_BE.Interfaces;
using KhaPOS_BE.Models;

using Microsoft.EntityFrameworkCore;

namespace KhaPOS_BE.Services;

public class ProductService : IProductService
{
    private readonly ProductContext _context;

    public ProductService(ProductContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Product>> Get()
    {
        var result = await _context.Products.ToListAsync();
        return result;
    }
}