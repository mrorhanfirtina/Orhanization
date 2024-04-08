using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.Stocks.Commands.Delete;

namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.Stocks.Validators;

public class DeleteStockValidator : AbstractValidator<DeleteStockCommand>
{
    public DeleteStockValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
