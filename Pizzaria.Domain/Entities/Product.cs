using System.IO.Compression;

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
      throw new ArgumentException("Nome do grupo é obrigatório");
    }

    if (min < 0)
    {
      throw new ArgumentException("Min não pode ser negativo");
    }

    if (max <= 0)
    {
      throw new ArgumentException("Max não pode ser menor ou igual a zero");
    }

    if (min > max)
    {
      throw new ArgumentException("Min não pode ser maior que Max");
    }

    if (_complementGroups.Any(x =>
      x.Name.Equals(name, StringComparison.OrdinalIgnoreCase)))
    {
      throw new ArgumentException("Já existe um grupo com esse nome");
    }

    if (!isRequired && min > 0)
    {
      throw new ArgumentException("Um grupo opcional não pode exigir quantidade mínima");
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
      throw new ArgumentException("Grupo não encontrado");
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
      throw new ArgumentException("Nome é obrigatório");
    }

    if (name.Length > 150)
    {
      throw new ArgumentException("Nome invalido");
    }

    if (price <= 0)
    {
      throw new ArgumentException("Preço invalido");
    }

    if (categoryId == Guid.Empty)
    {
      throw new ArgumentException("Categoria inválida");
    }

    Id = Guid.NewGuid();
    Name = name;
    Price = price;
    CategoryId = categoryId;
  }
}