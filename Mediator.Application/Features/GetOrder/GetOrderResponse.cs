
using Mediator.Application.Models;

namespace Mediator.Application.Features.GetOrder;

public sealed class GetOrderResponse(Order order)
{
    public Order Order { get; } = order;
}
