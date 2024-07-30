using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterDepositors.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterDepositors.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterDepositors.Validators;

public class UpdateActionParameterDepositorValidator : AbstractValidator<UpdateActionParameterDepositorCommand>
{
    public UpdateActionParameterDepositorValidator()
    {
        RuleFor(x => x.ActionParameterDepositor).SetValidator(new UpdateActionParameterDepositorDtoValidator());
    }
}
