using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItmStockAttrValues.Commands.Delete;

namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItmStockAttrValues.Validators;

public class DeleteReceiptItmStockAttrValueValidator : AbstractValidator<DeleteReceiptItmStockAttrValueCommand>
{
    public DeleteReceiptItmStockAttrValueValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
