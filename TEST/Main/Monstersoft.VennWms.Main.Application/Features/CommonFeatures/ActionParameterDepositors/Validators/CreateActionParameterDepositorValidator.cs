using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterDepositors.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterDepositors.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterDepositors.Validators;

public class CreateActionParameterDepositorValidator : AbstractValidator<CreateActionParameterDepositorCommand>
{
    public CreateActionParameterDepositorValidator()
    {
        RuleFor(x => x.ActionParameterDepositor).SetValidator(new CreateActionParameterDepositorDtoValidator());
    }
}
