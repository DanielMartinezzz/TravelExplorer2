
using System.Data;

namespace Application.Destinations.Update;

public class UpdateDestinationValidator : AbstractValidator<UpdateDestinationCommand>
{
    public UpdateDestinationValidator()
    {
        RuleFor(r => r.id)
            .NotEmpty();
        RuleFor(r => r.name)
            .NotEmpty();
        RuleFor(r => r.location)
            .NotEmpty();

    }
}
