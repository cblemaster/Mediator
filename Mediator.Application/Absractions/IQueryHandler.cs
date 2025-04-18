
namespace Mediator.Application.Absractions;

// This interface defines a generic request handler that takes in queries of type TQuery
// and returns responses of type TResponse
public interface IQueryHandler<in TQuery, TResponse>
{
    // Handles the given query asynchronously and returns a response
    // Parameters:
    // - query: The query object to be handled
    // - cancellationToken: A token to observe for cancellation requests (optional)
    // Returns:
    // - A Task representing the asynchronous operation, with a result of type TResponse
    Task<TResponse> HandleAsync(TQuery query, CancellationToken cancellationToken = default);
}
