namespace Pizzaria.Domain.Entities;
using Pizzaria.Domain.Common.Exceptions;

public class Category
{
  public Guid Id { get; private set; }

  public string Name { get; private set; }

  public Category(string name)
  {
    if (string.IsNullOrWhiteSpace(name))
    {
      throw new DomainException("Nome obrigatório");
    }

    Id = Guid.NewGuid();
    Name = name;
  }
}