using KhaPOS_BE.Data;
using KhaPOS_BE.Interfaces;
using KhaPOS_BE.Models;

using Microsoft.EntityFrameworkCore;

namespace KhaPOS_BE.Services;

public class TransactionService : ITransactionService
{
    private readonly Context _context;

    public TransactionService(Context context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Transaction>> Get()
    {
        var result = await _context.Transactions.ToListAsync();
        return result;
    }

    public async Task<Transaction> Add(Transaction dto)
    {
        _context.Transactions.Add(dto);
        await _context.SaveChangesAsync();
        return dto;
    }
}