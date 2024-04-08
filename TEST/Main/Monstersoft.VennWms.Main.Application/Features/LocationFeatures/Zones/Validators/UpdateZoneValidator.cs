using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateDtoRootValidators.LocationDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Zones.Commands.Update;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Zones.Validators;

public class UpdateZoneValidator : AbstractValidator<UpdateZoneCommand>
{
    public UpdateZoneValidator()
    {
        RuleFor(x => x.Zone).SetValidator(new UpdateZoneDtoValidator());
    }
}
