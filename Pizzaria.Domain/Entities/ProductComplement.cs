using Pizzaria.Domain.Common.Exceptions;
namespace Pizzaria.Domain.Entities;

public class ProductComplement
{
  public Guid Id { get; private set; }
  public Guid ProductId { get; private set; }
  public Guid ComplementId { get; private set; }
  public Guid ProductComplementGroupId { get; private set; } 
  public decimal Price { get; private set; }

  public ProductComplement(Guid productId, Guid complementId, Guid productComplementGroupId, decimal price)
  {
    if (productId == Guid.Empty)
    {
      throw new DomainException("Produto inválido");
    }

    if (complementId == Guid.Empty)
    {
      throw new DomainException("Complemento inválido");
    }

    if (price < 0)
    {
      throw new DomainException("Preço inválido");
    }

    ProductId = productId;
    ComplementId = complementId;
    ProductComplementGroupId = productComplementGroupId;
  }
}