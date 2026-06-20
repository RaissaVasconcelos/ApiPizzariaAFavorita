using Pizzaria.Domain.Entities;

namespace Pizzaria.Domain.Repositories;

public interface IComplementRepository
{
  Task<Complement?> GetByIdAsync(Guid id);
  Task<Complement?> GetByNameAsync(string name);
  Task<IEnumerable<Complement?>> GetAllAsync();
  
  Task AddAsync(Complement complement);
  Task UpdateAsync(Complement complement);
  Task DeleteAsync(Complement complement);
}