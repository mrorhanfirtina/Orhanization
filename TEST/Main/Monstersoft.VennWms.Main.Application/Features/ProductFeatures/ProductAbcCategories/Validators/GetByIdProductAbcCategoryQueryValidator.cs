using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAbcCategories.Queries.GetById;

namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAbcCategories.Validators;

public class GetByIdProductAbcCategoryQueryValidator : AbstractValidator<GetByIdProductAbcCategoryQuery>
{
    public GetByIdProductAbcCategoryQueryValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}


