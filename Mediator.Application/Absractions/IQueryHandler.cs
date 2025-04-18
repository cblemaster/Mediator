
namespace Mediator.Application.Absractions;

public interface IQueryHandler<in TQuery, TResponse>
{
    Task<TResponse> Handle(TQuery query, CancellationToken cancellationToken = default);
}
