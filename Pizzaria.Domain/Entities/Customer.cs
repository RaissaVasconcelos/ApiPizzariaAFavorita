namespace Pizzaria.Domain.Entities;

public class Customer
{
  public Guid Id { get; private set; }

  public string Name { get; private set; }

  public string Phone { get; private set; }

  public string Email { get; private set; }

  public Customer(string name, string email, string phone)
  {
    if (string.IsNullOrWhiteSpace(name))
    { 
      throw new ArgumentException("Nome obrigatório");
    }

    if (string.IsNullOrWhiteSpace(email))
    {
      throw new ArgumentException("Email obrigatório");
    }

    if (string.IsNullOrWhiteSpace(phone))
    {
      throw new ArgumentException("Telefone obrigatório");
    }

    if (name.Length > 150)
    {
      throw new ArgumentException("Nome deve possuir no máximo 150 caracteres");
    }

    if (email.Length > 150)
    {
      throw new ArgumentException("Email deve possuir no máximo 150 caracteres");
    }

    if (phone.Length > 20)
    {
      throw new ArgumentException("Telefone inválido");
    }

    if (email.Contains('@'))
    {
      throw new ArgumentException("Email invalido");
    }

    Id = Guid.NewGuid();
    Name = name;
    Email = email;
    Phone = phone;
  }
}