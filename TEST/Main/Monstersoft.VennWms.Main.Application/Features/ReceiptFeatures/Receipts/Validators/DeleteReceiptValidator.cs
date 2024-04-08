using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.Receipts.Commands.Delete;

namespace Monstersoft.VennWms.Main.Application.Features;

public class DeleteReceiptValidator : AbstractValidator<DeleteReceiptCommand>
{
    public DeleteReceiptValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
