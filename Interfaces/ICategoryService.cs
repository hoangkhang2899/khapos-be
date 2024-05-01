using KhaPOS_BE.Models;

namespace KhaPOS_BE.Interfaces;

public interface ICategoryService
{
    Task<IEnumerable<Category>> Get();
    Task<Category> Add(Category category);
}