
using Mediator.Application.Absractions;

namespace Mediator.Application.Features.GetOrder;

public sealed class GetOrderHandler : ICommandHandler<GetOrderQuery, GetOrderResponse>
{
    public Task<GetOrderResponse> Handle(GetOrderQuery command, CancellationToken cancellationToken = default) =>
        throw new NotImplementedException();
}
