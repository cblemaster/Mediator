
namespace Mediator.Application.Models;

public sealed class Order(Guid id, string name, string description, decimal price, DateTimeOffset createDate)
{
    public Guid Id { get; set; } = id;
    public string Name { get; set; } = name;
    public string Description { get; set; } = description;
    public decimal Price { get; set; } = price;
    public DateTimeOffset CreateDate { get; set; } = createDate;
}
