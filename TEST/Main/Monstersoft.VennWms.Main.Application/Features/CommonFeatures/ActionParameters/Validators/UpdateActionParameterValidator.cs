using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameters.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameters.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameters.Validators;

public class UpdateActionParameterValidator : AbstractValidator<UpdateActionParameterCommand>
{
    public UpdateActionParameterValidator()
    {
        RuleFor(x => x.ActionParameter).SetValidator(new UpdateActionParameterDtoValidator());
    }
}
