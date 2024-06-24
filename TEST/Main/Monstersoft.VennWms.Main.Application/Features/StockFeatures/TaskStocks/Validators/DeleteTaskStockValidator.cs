using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.TaskStocks.Commands.Delete;

namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.TaskStocks.Validators;

public class DeleteTaskStockValidator : AbstractValidator<DeleteTaskStockCommand>
{
    public DeleteTaskStockValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
