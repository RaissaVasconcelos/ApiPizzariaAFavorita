using Pizzaria.Domain.Entities;
namespace Pizzaria.Domain.Repositories;

public interface ICategoryRepository
{
  // declara o retorno
  Task<Category?> GetByIdAsync(Guid id);
  Task<Category?> GetByNameAsync(string name);
  Task<IEnumerable<Category>> GetAllAsync();

  Task AddAsync(Category category);
  Task UpdateAsync(Category category);
  Task DeleteAsync(Category category);
}