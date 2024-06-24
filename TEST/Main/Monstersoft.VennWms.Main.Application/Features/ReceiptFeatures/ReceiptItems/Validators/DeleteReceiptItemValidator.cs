using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItems.Commands.Delete;

namespace Monstersoft.VennWms.Main.Application.Features;

public class DeleteReceiptItemValidator : AbstractValidator<DeleteReceiptItemCommand>
{
    public DeleteReceiptItemValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
