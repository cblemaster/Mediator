
using Mediator.Application.Absractions;

namespace Mediator.Application.Features.CreateOrder;

public sealed class CreateOrderHandler : ICommandHandler<CreateOrderCommand, CreateOrderResponse>
{
    public async Task<CreateOrderResponse> HandleAsync(CreateOrderCommand command, CancellationToken cancellationToken = default) =>
        await Task.Run(() => new CreateOrderResponse(), cancellationToken);
}
