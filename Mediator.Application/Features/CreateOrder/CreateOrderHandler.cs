
using Mediator.Application.Absractions;

namespace Mediator.Application.Features.CreateOrder;

public sealed class CreateOrderHandler : ICommandHandler<CreateOrderCommand, CreateOrderResponse>
{
    public Task<CreateOrderResponse> Handle(CreateOrderCommand command, CancellationToken cancellationToken = default) =>
        throw new NotImplementedException();
}
