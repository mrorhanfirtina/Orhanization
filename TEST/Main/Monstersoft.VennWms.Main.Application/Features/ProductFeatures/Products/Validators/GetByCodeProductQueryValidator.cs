using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.Products.Queries.GetByCode;

namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.Products.Validators;

public class GetByCodeProductQueryValidator : AbstractValidator<GetByCodeProductQuery>
{
    public GetByCodeProductQueryValidator()
    {
        RuleFor(p => p.Code).NotEmpty().NotNull().MaximumLength(30);
    }
}

