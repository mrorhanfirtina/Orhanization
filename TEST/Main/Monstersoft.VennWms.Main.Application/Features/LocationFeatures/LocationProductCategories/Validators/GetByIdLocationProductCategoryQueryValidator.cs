using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductCategories.Queries.GetById;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductCategories.Validators;

public class GetByIdLocationProductCategoryQueryValidator : AbstractValidator<GetByIdLocationProductCategoryQuery>
{
    public GetByIdLocationProductCategoryQueryValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}

