using FluentValidation;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterDefaults;

public class GetByIdActionParameterDefaultQueryValidator : AbstractValidator<GetByIdActionParameterDefaultQuery>
{
    public GetByIdActionParameterDefaultQueryValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
