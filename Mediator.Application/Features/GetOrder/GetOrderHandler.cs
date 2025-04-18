
using Mediator.Application.Absractions;

namespace Mediator.Application.Features.GetOrder;

public sealed class GetOrderHandler : IQueryHandler<GetOrderQuery, GetOrderResponse>
{
    public Task<GetOrderResponse> Handle(GetOrderQuery query, CancellationToken cancellationToken = default) =>
        throw new NotImplementedException();
}
