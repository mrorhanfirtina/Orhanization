using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.LogStocks.Queries.GetById;

namespace Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.LogStocks.Validators;

public class GetByIdLogStockQueryValidator : AbstractValidator<GetByIdLogStockQuery>
{
    public GetByIdLogStockQueryValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
