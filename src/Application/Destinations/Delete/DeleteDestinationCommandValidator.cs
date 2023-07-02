

namespace Application.Destinations.Delete;

public class DeleteDestinationCommandValidator : AbstractValidator<DeleteDestinationCommand>
{
    public DeleteDestinationCommandValidator()
    {
        RuleFor(r => r.Id)
            .NotEmpty();
    }
}
