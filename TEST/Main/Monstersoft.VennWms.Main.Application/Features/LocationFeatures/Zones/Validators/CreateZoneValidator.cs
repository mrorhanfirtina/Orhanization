using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateDtoRootValidators.LocationDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Zones.Commands.Create;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Zones.Validators;

public class CreateZoneValidator : AbstractValidator<CreateZoneCommand>
{
    public CreateZoneValidator()
    {
        RuleFor(x => x.Zone).SetValidator(new CreateZoneDtoValidator());
    }
}
