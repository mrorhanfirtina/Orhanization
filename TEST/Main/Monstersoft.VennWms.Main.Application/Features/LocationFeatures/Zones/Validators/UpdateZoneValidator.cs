using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Zones.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Zones.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Zones.Validators;

public class UpdateZoneValidator : AbstractValidator<UpdateZoneCommand>
{
    public UpdateZoneValidator()
    {
        RuleFor(x => x.Zone).SetValidator(new UpdateZoneDtoValidator());
    }
}
