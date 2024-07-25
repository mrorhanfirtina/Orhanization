using FluentValidation;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterDefaults;

public class UpdateActionParameterDefaultValidator : AbstractValidator<UpdateActionParameterDefaultCommand>
{
    public UpdateActionParameterDefaultValidator()
    {
        RuleFor(x => x.ActionParameterDefault).SetValidator(new UpdateActionParameterDefaultDtoValidator());
    }
}
