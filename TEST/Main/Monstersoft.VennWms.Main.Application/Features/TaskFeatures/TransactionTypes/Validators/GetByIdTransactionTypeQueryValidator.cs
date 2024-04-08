using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TransactionTypes.Queries.GetById;

namespace Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TransactionTypes.Validators;

public class GetByIdTransactionTypeQueryValidator : AbstractValidator<GetByIdTransactionTypeQuery>
{
    public GetByIdTransactionTypeQueryValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotNull().InclusiveBetween(0, int.MaxValue);
    }
}
