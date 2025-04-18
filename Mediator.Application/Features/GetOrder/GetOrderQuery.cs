
namespace Mediator.Application.Features.GetOrder;

public sealed class GetOrderQuery(Guid id)
{
    public Guid Id { get; } = id;
}
