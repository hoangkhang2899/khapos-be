using KhaPOS_BE.Data;
using KhaPOS_BE.Interfaces;
using KhaPOS_BE.Models;

using Microsoft.EntityFrameworkCore;

namespace KhaPOS_BE.Services;

public class CategoryService : ICategoryService
{
    private readonly Context _context;

    public CategoryService(Context context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Category>> Get()
    {
        var result = await _context.Categories.Include(c => c.Products).ToListAsync();
        return result;
    }

    public async Task<Category> Add(Category category)
    {
        _context.Categories.Add(category);
        await _context.SaveChangesAsync();
        return category;
    }
}