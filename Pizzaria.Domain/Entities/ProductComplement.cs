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
      throw new ArgumentException("Produto inválido");
    }

    if (complementId == Guid.Empty)
    {
      throw new ArgumentException("Complemento inválido");
    }

    if (price < 0)
    {
      throw new ArgumentException("Preço inválido");
    }

    ProductId = productId;
    ComplementId = complementId;
    ProductComplementGroupId = productComplementGroupId;
  }
}