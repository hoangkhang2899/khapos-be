using KhaPOS_BE.Models;

namespace KhaPOS_BE.Interfaces;

public interface IProductService
{
    Task<IEnumerable<Product>> Get();
    Task<Product> Add(Product product);
}