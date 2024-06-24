using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.TransactionLogs.Commands.Delete;

namespace Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.TransactionLogs.Validators;

public class DeleteTransactionLogValidator : AbstractValidator<DeleteTransactionLogCommand>
{
    public DeleteTransactionLogValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
