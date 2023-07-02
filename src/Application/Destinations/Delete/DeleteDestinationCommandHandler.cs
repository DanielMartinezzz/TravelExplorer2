
using Domain.Customers;
using Domain.Destinations;
using Domain.Primitives;

namespace Application.Destinations.Delete;

internal class DeleteDestinationCommandHandler : IRequestHandler<DeleteDestinationCommand, ErrorOr<Unit>>

{
    private readonly IDestinationRepository _destinationRepository;
    private readonly IUnitOfWork _unitOfWork;

    public DeleteDestinationCommandHandler(IDestinationRepository destinationRepository, IUnitOfWork unitOfWork)
    {
        _destinationRepository = destinationRepository ?? throw new ArgumentNullException(nameof(destinationRepository));
        _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
    }

    public async Task<ErrorOr<Unit>> Handle(DeleteDestinationCommand command, CancellationToken cancellationToken)
    {
        if (await _destinationRepository.GetByIdAsync(new DestinationId(command.Id)) is not Destination destination )
        {
            return Error.NotFound("Destination.Not Found", "destination not found.");
        }

        _destinationRepository.Delete(destination);

        await _unitOfWork.SaveChangesAsync(cancellationToken);
        return Unit.Value;
    }
}
    
    

