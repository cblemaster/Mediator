
namespace Mediator.Application.Absractions;

public interface ICommandHandler<in TCommand, TResponse>
{
    Task<TResponse> Handle(TCommand command, CancellationToken cancellationToken = default);
}
