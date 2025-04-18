
namespace Mediator.Application.Absractions;

// This interface defines a generic request handler that takes in commands of type TCommand
// and returns responses of type TResponse
public interface ICommandHandler<in TCommand, TResponse>
{
    Task<TResponse> HandleAsync(TCommand command, CancellationToken cancellationToken = default);
}
