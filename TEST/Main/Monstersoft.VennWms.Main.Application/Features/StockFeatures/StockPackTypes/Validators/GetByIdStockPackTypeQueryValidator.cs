using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockPackTypes.Queries.GetById;

namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockPackTypes.Validators;

public class GetByIdStockPackTypeQueryValidator : AbstractValidator<GetByIdStockPackTypeQuery>
{
    public GetByIdStockPackTypeQueryValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
