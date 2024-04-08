using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateDtoRootValidators.LocationDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Locations.Commands.Update;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Locations.Validators;

public class UpdateLocationValidator : AbstractValidator<UpdateLocationCommand>
{
    public UpdateLocationValidator()
    {
        RuleFor(x => x.Location).SetValidator(new UpdateLocationDtoValidator());
    }
}
