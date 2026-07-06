namespace Pizzaria.Domain.Entities;
using Pizzaria.Domain.Common.Exceptions;

public class Address
{
  public Guid Id { get; private set; }

  public string Street { get; private set; }

  public string Number { get; private set; }

  public string Neighborhood { get; private set; }

  public string City { get; private set; }

  public string ZipCode { get; private set; }

  public Address(
    string street,
    string number,
    string neighborhood,
    string city,
    string zipcode
  )
  {
    if (string.IsNullOrWhiteSpace(street))
    {
      throw new DomainException("Rua obrigatória");
    }

    if (string.IsNullOrWhiteSpace(number))
    {
      throw new DomainException("Numero obrigatório");
    }

    if (string.IsNullOrWhiteSpace(neighborhood))
    {
      throw new DomainException("Bairro obrigatório");
    }

    if (string.IsNullOrWhiteSpace(city))
    {
      throw new DomainException("Cidade obrigatório");
    }
    
    if (string.IsNullOrWhiteSpace(zipcode))
    {
      throw new DomainException("Cep obrigatório");
    }

    Id = Guid.NewGuid();
    Street = street;
    Number = number;
    Neighborhood = neighborhood;
    City = city;
    ZipCode = zipcode;
  }
}