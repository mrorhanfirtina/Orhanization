using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptAttributeValues.Commands.Delete;

namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptAttributeValues.Validators;

public class DeleteReceiptAttributeValueValidator : AbstractValidator<DeleteReceiptAttributeValueCommand>
{
    public DeleteReceiptAttributeValueValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
