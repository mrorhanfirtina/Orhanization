using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationUnitConstraints.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationUnitConstraints.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationUnitConstraints.Validators;

public class UpdateLocationUnitConstraintValidator : AbstractValidator<UpdateLocationUnitConstraintCommand>
{
    public UpdateLocationUnitConstraintValidator()
    {
        RuleFor(x => x.LocationUnitConstraint).SetValidator(new UpdateLocationUnitConstraintDtoValidator());
    }
}

