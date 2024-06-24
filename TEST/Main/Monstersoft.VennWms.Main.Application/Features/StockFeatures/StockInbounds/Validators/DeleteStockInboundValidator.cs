using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockInbounds.Commands.Delete;

namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockInbounds.Validators;

public class DeleteStockInboundValidator : AbstractValidator<DeleteStockInboundCommand>
{
    public DeleteStockInboundValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
