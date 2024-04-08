using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateDtoRootValidators.DepositorDtos;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Depositors.Commands.Create;

namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Depositors.Validators;

public class CreateDepositorValidator : AbstractValidator<CreateDepositorCommand>
{
    public CreateDepositorValidator()
    {
        RuleFor(x => x.Depositor).SetValidator(new CreateDepositorDtoValidator());
    }
}
