using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.Receipts.Queries.GetByCode;

namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.Receipts.Validators;

public class GetByCodeReceiptQueryValidator : AbstractValidator<GetByCodeReceiptQuery>
{
    public GetByCodeReceiptQueryValidator()
    {
        RuleFor(p => p.Code).NotEmpty().NotNull().MaximumLength(30);
    }
}

