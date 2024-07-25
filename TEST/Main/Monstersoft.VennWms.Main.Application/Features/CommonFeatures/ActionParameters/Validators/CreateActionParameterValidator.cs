using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameters.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameters.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameters.Validators;

public class CreateActionParameterValidator : AbstractValidator<CreateActionParameterCommand>
{
    public CreateActionParameterValidator()
    {
        RuleFor(x => x.ActionParameter).SetValidator(new CreateActionParameterDtoValidator());
    }
}
