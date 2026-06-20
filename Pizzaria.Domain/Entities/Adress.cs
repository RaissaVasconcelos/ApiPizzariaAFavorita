namespace Pizzaria.Domain.Entities;

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
      throw new ArgumentException("Rua obrigatória");
    }

    if (string.IsNullOrWhiteSpace(number))
    {
      throw new ArgumentException("Numero obrigatório");
    }

    if (string.IsNullOrWhiteSpace(neighborhood))
    {
      throw new ArgumentException("Bairro obrigatório");
    }

    if (string.IsNullOrWhiteSpace(city))
    {
      throw new ArgumentException("Cidade obrigatório");
    }
    
    if (string.IsNullOrWhiteSpace(zipcode))
    {
      throw new ArgumentException("Cep obrigatório");
    }

    Id = Guid.NewGuid();
    Street = street;
    Number = number;
    Neighborhood = neighborhood;
    City = city;
    ZipCode = zipcode;
  }
}