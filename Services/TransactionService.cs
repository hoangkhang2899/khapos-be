using AutoMapper;

using KhaPOS_BE.Data;
using KhaPOS_BE.Interfaces;
using KhaPOS_BE.Models;

using Microsoft.EntityFrameworkCore;

namespace KhaPOS_BE.Services;

public class TransactionService : ITransactionService
{
    private readonly Context _context;
    private readonly IMapper _mapper;

    public TransactionService(Context context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<IEnumerable<Transaction>> Get()
    {
        var result = await _context.Transactions.ToListAsync();
        return result;
    }

    public async Task<Transaction> Add(TransactionAddDto dto)
    {
        var transaction = _mapper.Map<Transaction>(dto);
        _context.Transactions.Add(transaction);
        await _context.SaveChangesAsync();
        return transaction;
    }
}