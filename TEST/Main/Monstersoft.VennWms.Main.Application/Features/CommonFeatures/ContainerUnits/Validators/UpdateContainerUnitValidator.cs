using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateDtoRootValidators.CommonDtos;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ContainerUnits.Commands.Update;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ContainerUnits.Validators;

public class UpdateContainerUnitValidator : AbstractValidator<UpdateContainerUnitCommand>
{
    public UpdateContainerUnitValidator()
    {
        RuleFor(x => x.ContainerUnit).SetValidator(new UpdateContainerUnitDtoValidator());
    }
}
