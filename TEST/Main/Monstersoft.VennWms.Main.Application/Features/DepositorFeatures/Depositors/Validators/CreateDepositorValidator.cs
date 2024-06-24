using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Depositors.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Depositors.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Depositors.Validators;

public class CreateDepositorValidator : AbstractValidator<CreateDepositorCommand>
{
    public CreateDepositorValidator()
    {
        RuleFor(x => x.Depositor).SetValidator(new CreateDepositorDtoValidator());
    }
}
