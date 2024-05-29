using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductCategoryLists.Queries.GetById;

namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductCategoryLists.Validators;

public class GetByIdProductCategoryListQueryValidator : AbstractValidator<GetByIdProductCategoryListQuery>
{
    public GetByIdProductCategoryListQueryValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotNull().InclusiveBetween(1, int.MaxValue);
    }
}


