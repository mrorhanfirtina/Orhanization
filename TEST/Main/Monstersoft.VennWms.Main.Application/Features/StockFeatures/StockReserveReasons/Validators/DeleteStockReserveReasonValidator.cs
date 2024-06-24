using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockReserveReasons.Commands.Delete;

namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockReserveReasons.Validators;

public class DeleteStockReserveReasonValidator : AbstractValidator<DeleteStockReserveReasonCommand>
{
    public DeleteStockReserveReasonValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
