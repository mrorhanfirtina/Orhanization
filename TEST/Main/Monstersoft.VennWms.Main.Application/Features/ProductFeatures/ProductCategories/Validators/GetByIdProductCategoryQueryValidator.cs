using FluentValidation;

namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductCategories.Validators;

public class GetByIdProductCategoryQueryValidator : AbstractValidator<GetByIdProductCategoryQuery>
{
    public GetByIdProductCategoryQueryValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}

