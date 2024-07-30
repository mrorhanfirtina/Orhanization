using FluentValidation;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterDefaults;

public class UpdateActionParameterDefaultSubDtoValidator : AbstractValidator<UpdateActionParameterDefaultSubDto>
{
    public UpdateActionParameterDefaultSubDtoValidator()
    {
        RuleFor(p => p.ActionParameterId).NotEmpty().NotNull().InclusiveBetween(0, int.MaxValue);
        RuleFor(p => p.Value).NotEmpty().NotNull().MaximumLength(60);
    }
}
