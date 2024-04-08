using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateDtoRootValidators.LocationDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Buildings.Commands.Create;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Buildings.Validators;

public class CreateBuildingValidator : AbstractValidator<CreateBuildingCommand>
{
    public CreateBuildingValidator()
    {
        RuleFor(x => x.Building).SetValidator(new CreateBuildingDtoValidator());
    }
}
