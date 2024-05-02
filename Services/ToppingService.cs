using KhaPOS_BE.Data;
using KhaPOS_BE.Interfaces;
using KhaPOS_BE.Models;

using Microsoft.EntityFrameworkCore;

namespace KhaPOS_BE.Services;

public class ToppingService : IToppingService
{
    private readonly Context _context;

    public ToppingService(Context context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Topping>> Get()
    {
        var result = await _context.Toppings.ToListAsync();
        return result;
    }

    public async Task<Topping> Add(Topping dto)
    {
        _context.Toppings.Add(dto);
        await _context.SaveChangesAsync();
        return dto;
    }
}