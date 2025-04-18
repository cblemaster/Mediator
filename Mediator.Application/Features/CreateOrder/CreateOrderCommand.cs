
using Mediator.Application.Absractions;
using Mediator.Application.Models;

namespace Mediator.Application.Features.CreateOrder;

public sealed class CreateOrderCommand(Guid id, string name, string description, decimal price, DateTimeOffset createDate) : ICommand<CreateOrderResponse>
{
    public Order Order { get; } = new Order(id, name, description, price, createDate);
}
