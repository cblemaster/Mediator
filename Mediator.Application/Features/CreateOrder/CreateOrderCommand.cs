
using Mediator.Application.Absractions;

namespace Mediator.Application.Features.CreateOrder;

public sealed class CreateOrderCommand(Guid id, string name, string description, decimal price, DateTimeOffset createDate) : ICommand<CreateOrderResponse>
{
    public Guid Id { get; } = id;
    public string Name { get; } = name;
    public string Description { get; } = description;
    public decimal Price { get; } = price;
    public DateTimeOffset CreateDate { get; } = createDate;
}
