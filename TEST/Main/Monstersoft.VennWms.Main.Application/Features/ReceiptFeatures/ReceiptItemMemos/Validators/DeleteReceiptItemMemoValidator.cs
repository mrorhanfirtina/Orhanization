using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItemMemos.Commands.Delete;

namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItemMemos.Validators;

public class DeleteReceiptItemMemoValidator : AbstractValidator<DeleteReceiptItemMemoCommand>
{
    public DeleteReceiptItemMemoValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
