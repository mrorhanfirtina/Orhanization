using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateDtoRootValidators.DepositorDtos;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.UserDepositors.Commands.Update;

namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.UserDepositors.Validators;

public class UpdateUserDepositorValidator : AbstractValidator<UpdateUserDepositorCommand>
{
    public UpdateUserDepositorValidator()
    {
        RuleFor(x => x.UserDepositor).SetValidator(new UpdateUserDepositorDtoValidator());
    }
}
