using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TransactionTypes.Commands.Delete;

namespace Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TransactionTypes.Validators;

public class DeleteTransactionTypeValidator : AbstractValidator<DeleteTransactionTypeCommand>
{
    public DeleteTransactionTypeValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotNull().InclusiveBetween(0, int.MaxValue);
    }
}
