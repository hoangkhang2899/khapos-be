using AutoMapper;

using KhaPOS_BE.Data;
using KhaPOS_BE.Interfaces;
using KhaPOS_BE.Models;

using Microsoft.EntityFrameworkCore;

namespace KhaPOS_BE.Services;

public class ToppingService : IToppingService
{
    private readonly Context _context;
    private readonly IMapper _mapper;

    public ToppingService(Context context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<IEnumerable<Topping>> Get()
    {
        var result = await _context.Toppings.ToListAsync();
        return result;
    }

    public async Task<Topping> Add(ToppingAddDto dto)
    {
        var topping = _mapper.Map<Topping>(dto);
        _context.Toppings.Add(topping);
        await _context.SaveChangesAsync();
        return topping;
    }
}