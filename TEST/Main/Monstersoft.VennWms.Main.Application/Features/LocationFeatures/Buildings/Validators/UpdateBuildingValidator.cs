using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateDtoRootValidators.LocationDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Buildings.Commands.Update;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Buildings.Validators;

public class UpdateBuildingValidator : AbstractValidator<UpdateBuildingCommand>
{
    public UpdateBuildingValidator()
    {
        RuleFor(x => x.Building).SetValidator(new UpdateBuildingDtoValidator());
    }
}
