using Pizzaria.Domain.Entities;
namespace Pizzaria.Domain.Repositories;

public interface IProductRepository
{
  // declara o retorno
  Task<Product?> GetByIdAsync(Guid id);
  Task<Product?> GetByNameAsync(string name);
  Task<IEnumerable<Product>> GetAllAsync();

  Task AddAsync(Product Product);
  Task UpdateAsync(Product Product);
  Task DeleteAsync(Product Product);
}