using Pizzaria.Domain.Enums;
using Pizzaria.Domain.Common.Exceptions;

namespace Pizzaria.Domain.Entities;

public class Complement
{
  public Guid Id { get; private set; }
  public string Name { get; private set; }
  public string Description { get; private set; }
  public ComplementType Type { get; private set; }
  public bool IsActive { get; private set; }

  public void Active()
  {
    IsActive = true;
  }

  public void Desactive()
  {
    IsActive = false;
  }

  public Complement(string name, string description, ComplementType type)
  {
    if (string.IsNullOrWhiteSpace(name))
    {
      throw new DomainException("Nome obrigatório");
    }

    if (name.Length > 100)
    {
      throw new DomainException("Nome inválido");
    }

    if (description?.Length > 500)
    {
      throw new DomainException("Descrição invalida");
    }

    Id = Guid.NewGuid();
    Name = name;
    Description = description;
    Type = type;
    IsActive = true;
  }
}