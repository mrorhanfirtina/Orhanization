using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterDefaults.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterDefaults.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterDefaults.Validators;

public class CreateActionParameterDefaultValidator : AbstractValidator<CreateActionParameterDefaultCommand>
{
    public CreateActionParameterDefaultValidator()
    {
        RuleFor(x => x.ActionParameterDefault).SetValidator(new CreateActionParameterDefaultDtoValidator());
    }
}
