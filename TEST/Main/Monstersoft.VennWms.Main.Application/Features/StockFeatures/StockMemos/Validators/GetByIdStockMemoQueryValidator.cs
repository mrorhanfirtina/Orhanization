using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockMemos.Queries.GetById;

namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockMemos.Validators;

public class GetByIdStockMemoQueryValidator : AbstractValidator<GetByIdStockMemoQuery>
{
    public GetByIdStockMemoQueryValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
