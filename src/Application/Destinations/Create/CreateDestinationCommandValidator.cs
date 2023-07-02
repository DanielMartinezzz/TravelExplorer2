

namespace Application.Destinations.Create;

  public class CreateDestinationCommandValidator : AbstractValidator<CreateDestinationCommand> 
{ 
    public CreateDestinationCommandValidator()
    {
        RuleFor(r => r.Name).NotEmpty()
            .MaximumLength(50);

        RuleFor(r => r.Location).NotEmpty()
            .MaximumLength(100);

    }
}
    
    

