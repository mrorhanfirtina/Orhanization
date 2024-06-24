using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainers.Queries.GetById;

namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainers.Validators;

public class GetByIdStockContainerQueryValidator : AbstractValidator<GetByIdStockContainerQuery>
{
    public GetByIdStockContainerQueryValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
