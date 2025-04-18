
namespace Mediator.Application.Absractions;

// This interface defines a generic request handler that takes in commands of type TCommand
// and returns responses of type TResponse
public interface ICommandHandler<in TCommand, TResponse>
{
    // Handles the given command asynchronously and returns a response
    // Parameters:
    // - command: The command object to be handled
    // - cancellationToken: A token to observe for cancellation requests (optional)
    // Returns:
    // - A Task representing the asynchronous operation, with a result of type TResponse
    Task<TResponse> HandleAsync(TCommand command, CancellationToken cancellationToken = default);
}
