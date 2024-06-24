using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockMemos.Commands.Delete;

namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockMemos.Validators;

public class DeleteStockMemoValidator : AbstractValidator<DeleteStockMemoCommand>
{
    public DeleteStockMemoValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
