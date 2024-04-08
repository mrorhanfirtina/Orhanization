using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockAttributes.Queries.GetByCode;

namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockAttributes.Validators;

public class GetByCodeStockAttributeQueryValidator : AbstractValidator<GetByCodeStockAttributeQuery>
{
    public GetByCodeStockAttributeQueryValidator()
    {
        RuleFor(p => p.Code).NotEmpty().NotNull().MaximumLength(30);
    }
}

