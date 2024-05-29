using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Buildings.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Buildings.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Buildings.Validators;

public class UpdateBuildingValidator : AbstractValidator<UpdateBuildingCommand>
{
    public UpdateBuildingValidator()
    {
        RuleFor(x => x.Building).SetValidator(new UpdateBuildingDtoValidator());
    }
}
