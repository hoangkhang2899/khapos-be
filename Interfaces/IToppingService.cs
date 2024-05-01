using KhaPOS_BE.Models;

namespace KhaPOS_BE.Interfaces;

public interface IToppingService
{
    Task<IEnumerable<Topping>> Get();
    Task<Topping> Add(ToppingAddDto dto);
}