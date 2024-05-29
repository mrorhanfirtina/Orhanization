using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.UserDepositors.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.UserDepositors.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.UserDepositors.Validators;

public class UpdateUserDepositorValidator : AbstractValidator<UpdateUserDepositorCommand>
{
    public UpdateUserDepositorValidator()
    {
        RuleFor(x => x.UserDepositor).SetValidator(new UpdateUserDepositorDtoValidator());
    }
}
