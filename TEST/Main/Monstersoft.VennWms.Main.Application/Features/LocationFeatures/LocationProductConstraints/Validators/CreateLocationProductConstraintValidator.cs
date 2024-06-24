using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductConstraints.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductConstraints.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductConstraints.Validators;

public class CreateLocationProductConstraintValidator : AbstractValidator<CreateLocationProductConstraintCommand>
{
    public CreateLocationProductConstraintValidator()
    {
        RuleFor(x => x.LocationProductConstraint).SetValidator(new CreateLocationProductConstraintDtoValidator());
    }
}

