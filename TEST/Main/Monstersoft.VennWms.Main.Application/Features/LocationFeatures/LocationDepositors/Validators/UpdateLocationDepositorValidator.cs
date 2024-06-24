using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationDepositors.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationDepositors.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationDepositors.Validators;

public class UpdateLocationDepositorValidator : AbstractValidator<UpdateLocationDepositorCommand>
{
    public UpdateLocationDepositorValidator()
    {
        RuleFor(x => x.LocationDepositor).SetValidator(new UpdateLocationDepositorDtoValidator());
    }
}

