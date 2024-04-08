using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateDtoRootValidators.DepositorDtos;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Depositors.Commands.Update;

namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Depositors.Validators;

public class UpdateDepositorValidator : AbstractValidator<UpdateDepositorCommand>
{
    public UpdateDepositorValidator()
    {
        RuleFor(x => x.Depositor).SetValidator(new UpdateDepositorDtoValidator());
    }
}
