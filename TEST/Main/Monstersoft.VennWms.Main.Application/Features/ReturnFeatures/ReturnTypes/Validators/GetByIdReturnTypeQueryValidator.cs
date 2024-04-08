using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnTypes.Queries.GetById;

namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnTypes.Validators;

public class GetByIdReturnTypeQueryValidator : AbstractValidator<GetByIdReturnTypeQuery>
{
    public GetByIdReturnTypeQueryValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
