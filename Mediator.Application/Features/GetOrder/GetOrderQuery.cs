
using Mediator.Application.Absractions;

namespace Mediator.Application.Features.GetOrder;

public sealed class GetOrderQuery(Guid id) : IQuery<GetOrderResponse>
{
    public Guid Id { get; } = id;
}
