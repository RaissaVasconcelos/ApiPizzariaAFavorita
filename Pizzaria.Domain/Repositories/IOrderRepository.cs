using Pizzaria.Domain.Entities;
namespace Pizzaria.Domain.Repositories;

public interface IOrderRepository
{
  // declara o retorno
  Task<Order?> GetByIdAsync(Guid id);
  Task<Order?> GetByNameAsync(string name);
  Task<IEnumerable<Order>> GetAllAsync();

  Task AddAsync(Order order);
  Task UpdateAsync(Order order);
  Task DeleteAsync(Order order);
}