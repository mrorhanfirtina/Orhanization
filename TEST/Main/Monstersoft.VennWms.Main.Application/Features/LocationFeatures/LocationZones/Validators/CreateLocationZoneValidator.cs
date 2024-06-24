using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationZones.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationZones.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationZones.Validators;

public class CreateLocationZoneValidator : AbstractValidator<CreateLocationZoneCommand>
{
    public CreateLocationZoneValidator()
    {
        RuleFor(x => x.LocationZone).SetValidator(new CreateLocationZoneDtoValidator());
    }
}
