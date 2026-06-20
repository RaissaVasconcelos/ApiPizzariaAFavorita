namespace Pizzaria.Domain.Entities;

public class ProductComplementGroup
{
  public Guid Id { get; private set; }
  public Guid ProductId { get; private set; }
  public string Name { get; private set; }
  public int MinSelection { get; private set; }
  public int MaxSelection { get; private set; }
  public bool IsRequired { get; private set; }

  private readonly List<ProductComplement> _complements = [];
  public IReadOnlyCollection<ProductComplement> Complements => _complements.AsReadOnly();

  public ProductComplement AddComplement(Guid complementId, decimal price)
  {
    if (Guid.Empty == complementId)
    {
      throw new ArgumentException("Complemento é obrigatório");
    }

    if (price < 0)
    {
      throw new ArgumentException("Preço inválido");
    }
    
    var alreadyExists = _complements.Any(x => x.ComplementId == complementId);
    
    if (alreadyExists)
    {
      throw new ArgumentException("Este complemento ja foi adicionado ao grupo");
    }

    var productComplement = new ProductComplement(ProductId, complementId, Id, price);

    _complements.Add(productComplement);

    return productComplement;
  }

  public void RemoveComplement(Guid complementId)
  {
    var productComplement = _complements.FirstOrDefault(x => x.ComplementId == complementId);

    if (productComplement is null)
    {
      throw new ArgumentException("Complemento não encontrado");
    }
  }

  public ProductComplementGroup(string name, Guid productId, int minSelection, int maxSelection)
  {
    if (string.IsNullOrEmpty(name))
    {
      throw new ArgumentException("Nome é obrigatório");
    }
    if (productId == Guid.Empty)
    {
      throw new ArgumentException("Id do produto é obrigatório");
    }
    if (minSelection < 0)
    {
      throw new ArgumentException("Quantidade minima invalida");
    }
    if (maxSelection <= 0)
    {
      throw new ArgumentException("Quantidade máxima invalida");
    }
    if (minSelection < maxSelection)
    {
      throw new ArgumentException("Quantidade máxima não pode ser menor que a minima");
    }
    if (!IsRequired && minSelection > 0)
    {
      throw new ArgumentException("Um grupo opcional não pode exigir quantidade minima");
    }

    Id = Guid.NewGuid();
    Name = name;
    ProductId = productId;
    MinSelection = minSelection;
    MaxSelection = maxSelection;
  }
}