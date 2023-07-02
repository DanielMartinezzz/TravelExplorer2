

using Domain.Destinations;
using Domain.Primitives;
using Domain.ValueObjects;
using ErrorOr;
using MediatR;

namespace Application.Destinations.Update;

internal sealed class UpdateDestinationCommandHandler : IRequestHandler<UpdateDestinationCommand, ErrorOr<Unit>>
{
    private readonly IDestinationRepository _destinationRepository;
    private readonly IUnitOfWork _unitOfWork;

    public UpdateDestinationCommandHandler(IDestinationRepository destinationRepository, IUnitOfWork unitOfWork)
    {
        _destinationRepository = destinationRepository ?? throw new ArgumentNullException(nameof(destinationRepository));
        _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
    }

    public async Task<ErrorOr<Unit>> Handle(UpdateDestinationCommand command, CancellationToken cancellationToken)
    {
        Destination destination = Destination.UpdateDestination(command.id, command.name,
                command.location);

        _destinationRepository.Update(destination);

        await _unitOfWork.SaveChangesAsync(cancellationToken);

        return Unit.Value;


    }
}

