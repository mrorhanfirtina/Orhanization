using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TransactionTypes.Queries.GetByCode;

namespace Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TransactionTypes.Validators;

public class GetByCodeTransactionTypeQueryValidator : AbstractValidator<GetByCodeTransactionTypeQuery>
{
    public GetByCodeTransactionTypeQueryValidator()
    {
        RuleFor(p => p.Code).NotEmpty().NotNull().MaximumLength(30);
    }
}

