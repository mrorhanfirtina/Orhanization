using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.Stocks.Queries.GetById;

namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockReserveReasons.Validators;

public class GetByIdStockQueryValidator : AbstractValidator<GetByIdStockQuery>
{
    public GetByIdStockQueryValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
