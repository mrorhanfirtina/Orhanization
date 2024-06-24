using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockAttributes.Queries.GetById;

namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockAttributes.Validators;

public class GetByIdStockAttributeQueryValidator : AbstractValidator<GetByIdStockAttributeQuery>
{
    public GetByIdStockAttributeQueryValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
