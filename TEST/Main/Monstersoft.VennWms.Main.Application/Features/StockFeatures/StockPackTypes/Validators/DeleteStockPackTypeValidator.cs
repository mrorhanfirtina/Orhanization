using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockPackTypes.Commands.Delete;

namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockPackTypes.Validators;

public class DeleteStockPackTypeValidator : AbstractValidator<DeleteStockPackTypeCommand>
{
    public DeleteStockPackTypeValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
