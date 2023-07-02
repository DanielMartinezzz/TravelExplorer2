
using ErrorOr;
namespace Application.Destinations.Update;

public record UpdateDestinationCommand
(
    Guid id
    , string name
    , string location

    ) : IRequest<ErrorOr<Unit>>;
