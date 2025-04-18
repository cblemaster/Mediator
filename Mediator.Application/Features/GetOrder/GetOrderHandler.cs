
using Mediator.Application.Absractions;
using Mediator.Application.Models;

namespace Mediator.Application.Features.GetOrder;

public sealed class GetOrderHandler : IQueryHandler<GetOrderQuery, GetOrderResponse>
{
    // not a real implementation
    public async Task<GetOrderResponse> HandleAsync(GetOrderQuery query, CancellationToken cancellationToken = default) =>
        await Task.Run(() => new GetOrderResponse(new Order(query.Id, "Sample order", "Sample order", 100.0m, DateTimeOffset.UtcNow)), cancellationToken);
}
