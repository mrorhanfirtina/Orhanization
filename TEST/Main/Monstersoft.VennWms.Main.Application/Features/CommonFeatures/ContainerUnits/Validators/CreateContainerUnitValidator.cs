using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateDtoRootValidators.CommonDtos;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ContainerUnits.Commands.Create;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ContainerUnits.Validators;

public class CreateContainerUnitValidator : AbstractValidator<CreateContainerUnitCommand>
{
    public CreateContainerUnitValidator()
    {
        RuleFor(x => x.ContainerUnit).SetValidator(new CreateContainerUnitDtoValidator());
    }
}
