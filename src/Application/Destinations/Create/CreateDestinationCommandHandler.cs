using Domain.Destinations;
using Domain.Primitives;
using Domain.ValueObjects;
using MediatR;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Application.Destinations.Create;

public sealed class CreateDestinationCommandHandler : IRequestHandler<CreateDestinationCommand, ErrorOr<Guid>>
{
    private readonly IDestinationRepository _destinationRepository;

    private readonly IUnitOfWork _unitOfWork;
    public CreateDestinationCommandHandler(IDestinationRepository destinationRepository, IUnitOfWork unitOfWork)
    {
        _destinationRepository = destinationRepository ?? throw new ArgumentNullException (nameof(destinationRepository));
        _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
    }



    public async Task<Unit> Handle(CreateDestinationCommand command, CancellationToken cancellationToken)
    {
        var destination = new Destination(
           new DestinationId(Guid.NewGuid()),
           command.Name,
           command.Location
           );

        

         _destinationRepository.Add(destination);
         await _unitOfWork.SaveChangesAsync(cancellationToken);
        return Unit.Value;







    }

    Task<ErrorOr<Guid>> IRequestHandler<CreateDestinationCommand, ErrorOr<Guid>>.Handle(CreateDestinationCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
    
    

