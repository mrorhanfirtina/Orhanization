using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockAttributeValues.Commands.Delete;

namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockAttributeValues.Validators;

public class DeleteStockAttributeValueValidator : AbstractValidator<DeleteStockAttributeValueCommand>
{
    public DeleteStockAttributeValueValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
