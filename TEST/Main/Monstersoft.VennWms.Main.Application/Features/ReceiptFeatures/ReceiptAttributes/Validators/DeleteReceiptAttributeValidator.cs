using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptAttributes.Commands.Delete;

namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptAttributes.Validators;

public class DeleteReceiptAttributeValidator : AbstractValidator<DeleteReceiptAttributeCommand>
{
    public DeleteReceiptAttributeValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
