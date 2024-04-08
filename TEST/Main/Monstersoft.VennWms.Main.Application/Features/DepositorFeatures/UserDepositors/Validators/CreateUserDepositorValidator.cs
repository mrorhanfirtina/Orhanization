using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateDtoRootValidators.DepositorDtos;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.UserDepositors.Commands.Create;

namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.UserDepositors.Validators;

public class CreateUserDepositorValidator : AbstractValidator<CreateUserDepositorCommand>
{
    public CreateUserDepositorValidator()
    {
        RuleFor(x => x.UserDepositor).SetValidator(new CreateUserDepositorDtoValidator());
    }
}
