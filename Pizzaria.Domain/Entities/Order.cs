using Pizzaria.Domain.Enums;

namespace Pizzaria.Domain.Entities;

public class Order
{
  public Guid Id { get; private set; }

  public OrderStatus Status { get; private set; }

  // readonly só pode receber valor durante a declaração da classe, não pode receber variação
  private readonly List<OrderItem> _items = [];

  public Guid CustomerId { get; private set; }

  public Customer Customer { get; private set; }

  public Guid AddressId { get; private set; }

  public Address Address { get; private set; }

  public IReadOnlyCollection<OrderItem> Items => _items;

  public DateTime CreatedAt { get; private set; }

  public PaymentMethod PaymentMethod { get; private set; }

  public string Observation { get; private set; }

  public Order(
    Guid customerId,
    Guid addressId,
    string observation
  )
  {
    if (customerId == Guid.Empty)
    {
      throw new ArgumentException("Cliente inválido");
    }

    if (addressId == Guid.Empty)
    {
      throw new ArgumentException("Endereço inválido");
    }

    Id = Guid.NewGuid();
    Status = OrderStatus.Pending;
    CreatedAt = DateTime.UtcNow;
    CustomerId = customerId;
    AddressId = addressId;
    Observation = observation;
  }

  public void AddItem(OrderItem item)
  {
    ArgumentNullException.ThrowIfNull(item);
   _items.Add(item); 
  }

  public void RemoveItem(Guid productId)
  {
    var item = _items.FirstOrDefault(
      x => x.ProductId == productId
    );

    if (item is null)
    {
      throw new InvalidOperationException(
        "Item não encontrado"
      );
    }

    _items.Remove(item);
  }

  public decimal Total()
  {
    return decimal.Round(
      _items.Sum(x => x.Total()),
      2
    );
  }

  public void Validate()
  {
    if (!_items.Any())
    {
      throw new InvalidDataException("Pedido deve possuir ao menos um item");
    }
  }

  public void ChangeStatus(OrderStatus newStatus)
    {
        Validate();

        switch (Status)
        {
            case OrderStatus.Pending:

                if (newStatus != OrderStatus.Preparing &&
                    newStatus != OrderStatus.Cancelled)
                {
                    throw new InvalidOperationException(
                        "Status inválido"
                    );
                }

                break;

            case OrderStatus.Preparing:

                if (newStatus != OrderStatus.Ready &&
                    newStatus != OrderStatus.Cancelled)
                {
                    throw new InvalidOperationException(
                        "Status inválido"
                    );
                }

                break;

            case OrderStatus.Ready:

                if (newStatus != OrderStatus.OutForDelivery)
                {
                    throw new InvalidOperationException(
                        "Status inválido"
                    );
                }

                break;

            case OrderStatus.OutForDelivery:

                if (newStatus != OrderStatus.Delivered)
                {
                    throw new InvalidOperationException(
                        "Status inválido"
                    );
                }

                break;

            case OrderStatus.Delivered:
                throw new InvalidOperationException(
                    "Pedido já foi entregue"
                );

            case OrderStatus.Cancelled:
                throw new InvalidOperationException(
                    "Pedido cancelado"
                );
        }

        Status = newStatus;
    }
}