using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductCategoryLists.Queries.GetByCode;

namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductCategoryLists.Validators;

public class GetByCodeProductCategoryListQueryValidator : AbstractValidator<GetByCodeProductCategoryListQuery>
{
    public GetByCodeProductCategoryListQueryValidator()
    {
        RuleFor(p => p.Code).NotEmpty().NotNull().MaximumLength(30);
    }
}


