using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductConstraints.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductConstraints.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductConstraints.Validators;

public class UpdateLocationProductConstraintValidator : AbstractValidator<UpdateLocationProductConstraintCommand>
{
    public UpdateLocationProductConstraintValidator()
    {
        RuleFor(x => x.LocationProductConstraint).SetValidator(new UpdateLocationProductConstraintDtoValidator());
    }
}

