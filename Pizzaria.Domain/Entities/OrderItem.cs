using Pizzaria.Domain.Common.Exceptions;
namespace Pizzaria.Domain.Entities;

public class OrderItem
{
  public Guid ProductId { get; private set; }

  public Product Product { get; private set; }

  public int Quantity { get; private set; }

  public decimal Unitprice { get; private set; }

  public OrderItem(
    Guid productId,
    int quantity,
    decimal unitPrice
  )
  {
    if (productId == Guid.Empty)
    {
      throw new DomainException("Produto inválido");
    }

    if (quantity <= 0)
    {
      throw new DomainException("A quantidade deve ser maior que zero");
    }

    if (unitPrice <= 0)
    {
      throw new DomainException("O preço unitário deve ser maior que zero");
    }

    ProductId = productId;
    Quantity = quantity;
    Unitprice = unitPrice;
  }

  public void ChangeQuantity(int quantity)
  {
      if (quantity <= 0)
    {
      throw new DomainException("Quantidade inválida");
    }

    Quantity = quantity;
  }

  public decimal Total()
  {
    return decimal.Round(Quantity * Unitprice, 2);
  }
}