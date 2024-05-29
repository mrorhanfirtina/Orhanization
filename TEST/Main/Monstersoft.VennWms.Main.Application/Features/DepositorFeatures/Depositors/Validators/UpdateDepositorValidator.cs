using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Depositors.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Depositors.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Depositors.Validators;

public class UpdateDepositorValidator : AbstractValidator<UpdateDepositorCommand>
{
    public UpdateDepositorValidator()
    {
        RuleFor(x => x.Depositor).SetValidator(new UpdateDepositorDtoValidator());
    }
}
