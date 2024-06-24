using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockAttributeValues.Queries.GetById;

namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockAttributeValues.Validators;

public class GetByIdStockAttributeValueQueryValidator : AbstractValidator<GetByIdStockAttributeValueQuery>
{
    public GetByIdStockAttributeValueQueryValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
