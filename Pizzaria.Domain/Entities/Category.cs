namespace Pizzaria.Domain.Entities;

public class Category
{
  public Guid Id { get; private set; }

  public string Name { get; private set; }

  public Category(string name)
  {
    if (string.IsNullOrWhiteSpace(name))
    {
      throw new ArgumentException("Nome obrigatório");
    }

    Id = Guid.NewGuid();
    Name = name;
  }
}