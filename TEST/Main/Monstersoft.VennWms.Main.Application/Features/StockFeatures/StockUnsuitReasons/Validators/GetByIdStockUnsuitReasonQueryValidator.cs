using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockUnsuitReasons.Queries.GetById;

namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockUnsuitReasons.Validators;

public class GetByIdStockUnsuitReasonQueryValidator : AbstractValidator<GetByIdStockUnsuitReasonQuery>
{
    public GetByIdStockUnsuitReasonQueryValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
