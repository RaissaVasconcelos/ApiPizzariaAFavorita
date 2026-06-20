using Pizzaria.Domain.Entities;
namespace Pizzaria.Domain.Repositories;

public interface ICustomerRepository
{
  // declara o retorno
  Task<Customer?> GetByIdAsync(Guid id);
  Task<Customer?> GetByNameAsync(string name);
  Task<IEnumerable<Customer>> GetAllAsync();

  Task AddAsync(Customer customer);
  Task UpdateAsync(Customer customer);
  Task DeleteAsync(Customer customer);
}