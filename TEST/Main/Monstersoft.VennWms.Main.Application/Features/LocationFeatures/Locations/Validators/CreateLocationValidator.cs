using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Locations.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Locations.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Locations.Validators;

public class CreateLocationValidator : AbstractValidator<CreateLocationCommand>
{
    public CreateLocationValidator()
    {
        RuleFor(x => x.Location).SetValidator(new CreateLocationDtoValidator());
    }
}
