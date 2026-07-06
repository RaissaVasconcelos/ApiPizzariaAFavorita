using Pizzaria.Domain.Common.Exceptions;

namespace Pizzaria.Domain.Entities;

public class Product
{
  public Guid Id { get; private set; }
  public string Name { get; private set; }
  public decimal Price { get; private set; }
  public Guid CategoryId { get; private set; }
  public string Description { get; private set; } = string.Empty;
  public bool IsActive { get; private set; } = true;

  private readonly List<ProductComplementGroup> _complementGroups = [];
  public IReadOnlyCollection<ProductComplementGroup> ComplementGroups => _complementGroups.AsReadOnly();

  public ProductComplementGroup AddProductComplementGroup(
    string name,
    int min,
    int max,
    bool isRequired)
  {
    if (string.IsNullOrWhiteSpace(name))
    {
      throw new DomainException("Nome do grupo é obrigatório");
    }

    if (min < 0)
    {
      throw new DomainException("Min não pode ser negativo");
    }

    if (max <= 0)
    {
      throw new DomainException("Max não pode ser menor ou igual a zero");
    }

    if (min > max)
    {
      throw new DomainException("Min não pode ser maior que Max");
    }

    if (_complementGroups.Any(x =>
      x.Name.Equals(name, StringComparison.OrdinalIgnoreCase)))
    {
      throw new DomainException("Já existe um grupo com esse nome");
    }

    if (!isRequired && min > 0)
    {
      throw new DomainException("Um grupo opcional não pode exigir quantidade mínima");
    }

    var group = new ProductComplementGroup(name, Id, min, max);

    _complementGroups.Add(group);

    return group;
  }

  public void RemoveProductComplement(Guid groupId)
  {
    var group = _complementGroups.FirstOrDefault(x => x.Id == groupId);

    if (group is null)
    {
      throw new DomainException("Grupo não encontrado");
    }

    _complementGroups.Remove(group);
  }

  public Product(
    string name,
    decimal price,
    Guid categoryId
  )
  {

    if (string.IsNullOrWhiteSpace(name))
    {
      throw new DomainException("Nome é obrigatório");
    }

    if (name.Length > 150)
    {
      throw new DomainException("Nome invalido");
    }

    if (price <= 0)
    {
      throw new DomainException("Preço invalido");
    }

    if (categoryId == Guid.Empty)
    {
      throw new DomainException("Categoria inválida");
    }

    Id = Guid.NewGuid();
    Name = name;
    Price = price;
    CategoryId = categoryId;
  }
}