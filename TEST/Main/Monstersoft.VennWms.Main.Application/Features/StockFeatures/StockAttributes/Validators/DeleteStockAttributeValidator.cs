using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockAttributes.Commands.Delete;

namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockAttributes.Validators;

public class DeleteStockAttributeValidator : AbstractValidator<DeleteStockAttributeCommand>
{
    public DeleteStockAttributeValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
