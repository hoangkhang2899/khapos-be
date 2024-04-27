using KhaPOS_BE.Data;
using KhaPOS_BE.Interfaces;
using KhaPOS_BE.Models;

using Microsoft.EntityFrameworkCore;

namespace KhaPOS_BE.Services;

public class ProductService : IProductService
{
    private readonly Context _context;

    public ProductService(Context context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Product>> Get()
    {
        var result = await _context.Products.ToListAsync();
        return result;
    }
}