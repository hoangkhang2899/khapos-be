using KhaPOS_BE.Models;

namespace KhaPOS_BE.Interfaces;

public interface ITransactionService
{
    Task<IEnumerable<Transaction>> Get();
    Task<Transaction> Add(TransactionAddDto dto);
}