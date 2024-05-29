using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationZones.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationZones.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationZones.Validators;

public class UpdateLocationZoneValidator : AbstractValidator<UpdateLocationZoneCommand>
{
    public UpdateLocationZoneValidator()
    {
        RuleFor(x => x.LocationZone).SetValidator(new UpdateLocationZoneDtoValidator());
    }
}
