
using Mediator.Application.Models;

namespace Mediator.Application.Features.CreateOrder;

public sealed class CreateOrderCommand(Guid id, string name, string description, decimal price, DateTimeOffset createDate)
{
    public Order Order { get; } = new Order(id, name, description, price, createDate);
}
