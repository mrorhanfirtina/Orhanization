using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Buildings.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Buildings.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Buildings.Validators;

public class CreateBuildingValidator : AbstractValidator<CreateBuildingCommand>
{
    public CreateBuildingValidator()
    {
        RuleFor(x => x.Building).SetValidator(new CreateBuildingDtoValidator());
    }
}
