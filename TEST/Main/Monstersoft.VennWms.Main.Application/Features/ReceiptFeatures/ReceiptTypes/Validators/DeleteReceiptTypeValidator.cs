using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptTypes.Commands.Delete;

namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptTypes.Validators;

public class DeleteReceiptTypeValidator : AbstractValidator<DeleteReceiptTypeCommand>
{
    public DeleteReceiptTypeValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
