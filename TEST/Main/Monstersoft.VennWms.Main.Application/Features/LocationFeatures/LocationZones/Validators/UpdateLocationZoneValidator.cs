using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateDtoRootValidators.LocationDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationZones.Commands.Update;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationZones.Validators;

public class UpdateLocationZoneValidator : AbstractValidator<UpdateLocationZoneCommand>
{
    public UpdateLocationZoneValidator()
    {
        RuleFor(x => x.LocationZone).SetValidator(new UpdateLocationZoneDtoValidator());
    }
}
