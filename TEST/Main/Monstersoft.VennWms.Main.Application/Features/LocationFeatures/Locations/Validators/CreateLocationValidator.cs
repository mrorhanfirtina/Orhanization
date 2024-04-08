using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateDtoRootValidators.LocationDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Locations.Commands.Create;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Locations.Validators;

public class CreateLocationValidator : AbstractValidator<CreateLocationCommand>
{
    public CreateLocationValidator()
    {
        RuleFor(x => x.Location).SetValidator(new CreateLocationDtoValidator());
    }
}
