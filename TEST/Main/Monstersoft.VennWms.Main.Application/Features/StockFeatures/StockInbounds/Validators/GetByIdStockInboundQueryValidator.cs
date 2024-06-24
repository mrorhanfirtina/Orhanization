using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockInbounds.Queries.GetById;

namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockInbounds.Validators;

public class GetByIdStockInboundQueryValidator : AbstractValidator<GetByIdStockInboundQuery>
{
    public GetByIdStockInboundQueryValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
