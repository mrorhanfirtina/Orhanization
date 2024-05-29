using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationUnitConstraints.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationUnitConstraints.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationUnitConstraints.Validators;

public class CreateLocationUnitConstraintValidator : AbstractValidator<CreateLocationUnitConstraintCommand>
{
    public CreateLocationUnitConstraintValidator()
    {
        RuleFor(x => x.LocationUnitConstraint).SetValidator(new CreateLocationUnitConstraintDtoValidator());
    }
}

