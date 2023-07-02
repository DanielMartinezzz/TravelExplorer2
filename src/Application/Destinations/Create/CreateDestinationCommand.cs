using MediatR;

namespace Application.Destinations.Create;

    public record CreateDestinationCommand
    (
      string Name,
      string Location
     ): IRequest<ErrorOr<Guid>>;


