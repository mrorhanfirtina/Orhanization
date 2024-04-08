using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ContainerUnits.Commands.Delete;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ContainerUnits.Validators;

public class DeleteContainerUnitValidator : AbstractValidator<DeleteContainerUnitCommand>
{
    public DeleteContainerUnitValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotNull().InclusiveBetween(0, int.MaxValue);
    }
}
