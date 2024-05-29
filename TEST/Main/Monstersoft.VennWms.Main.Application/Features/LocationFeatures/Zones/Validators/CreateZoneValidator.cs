using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Zones.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Zones.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Zones.Validators;

public class CreateZoneValidator : AbstractValidator<CreateZoneCommand>
{
    public CreateZoneValidator()
    {
        RuleFor(x => x.Zone).SetValidator(new CreateZoneDtoValidator());
    }
}
