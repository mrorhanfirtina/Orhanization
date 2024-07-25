using FluentValidation;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterUsers.Validators;

public class GetByIdActionParameterUserValidator : AbstractValidator<GetByIdActionParameterUserQuery>
{
    public GetByIdActionParameterUserValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
