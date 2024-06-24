using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ContainerUnits.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ContainerUnits.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ContainerUnits.Validators;

public class CreateContainerUnitValidator : AbstractValidator<CreateContainerUnitCommand>
{
    public CreateContainerUnitValidator()
    {
        RuleFor(x => x.ContainerUnit).SetValidator(new CreateContainerUnitDtoValidator());
    }
}
