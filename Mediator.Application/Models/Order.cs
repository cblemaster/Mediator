
namespace Mediator.Application.Models;

public sealed class Order(Guid id, string name, string description, decimal price, DateTimeOffset createDate)
{
    public Guid Id { get; } = id;
    public string Name { get; } = name;
    public string Description { get; } = description;
    public decimal Price { get; } = price;
    public DateTimeOffset CreateDate { get; } = createDate;
}
