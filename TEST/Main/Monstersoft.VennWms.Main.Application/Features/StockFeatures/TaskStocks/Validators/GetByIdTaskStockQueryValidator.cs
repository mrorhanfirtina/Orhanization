using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.TaskStocks.Queries.GetById;

namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.TaskStocks.Validators;

public class GetByIdTaskStockQueryValidator : AbstractValidator<GetByIdTaskStockQuery>
{
    public GetByIdTaskStockQueryValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
