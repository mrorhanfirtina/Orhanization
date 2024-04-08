using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.TransactionLogs.Queries.GetById;

namespace Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.TransactionLogs.Validators;

public class GetByIdTransactionLogQueryValidator : AbstractValidator<GetByIdTransactionLogQuery>
{
    public GetByIdTransactionLogQueryValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
