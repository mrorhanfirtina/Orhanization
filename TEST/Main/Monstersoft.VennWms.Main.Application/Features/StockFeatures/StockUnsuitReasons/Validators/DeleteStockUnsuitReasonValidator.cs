using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockUnsuitReasons.Commands.Delete;

namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockUnsuitReasons.Validators;

public class DeleteStockUnsuitReasonValidator : AbstractValidator<DeleteStockUnsuitReasonCommand>
{
    public DeleteStockUnsuitReasonValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
