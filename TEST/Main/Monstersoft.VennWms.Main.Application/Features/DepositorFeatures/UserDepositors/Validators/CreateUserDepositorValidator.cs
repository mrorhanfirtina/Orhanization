using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.UserDepositors.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.UserDepositors.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.UserDepositors.Validators;

public class CreateUserDepositorValidator : AbstractValidator<CreateUserDepositorCommand>
{
    public CreateUserDepositorValidator()
    {
        RuleFor(x => x.UserDepositor).SetValidator(new CreateUserDepositorDtoValidator());
    }
}
