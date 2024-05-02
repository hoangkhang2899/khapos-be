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
        var result = await _context.Products.Include(p => p.CategoryId).ToListAsync();
        return result;
    }

    public async Task<Product> Add(Product product)
    {
        _context.Products.Add(product);
        await _context.SaveChangesAsync();
        return product;
    }
}