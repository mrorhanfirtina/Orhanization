using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptTypes.Queries.GetByCode;

namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptTypes.Validators;

public class GetByCodeReceiptTypeQueryValidator : AbstractValidator<GetByCodeReceiptTypeQuery>
{
    public GetByCodeReceiptTypeQueryValidator()
    {
        RuleFor(p => p.Code).NotEmpty().NotNull().MaximumLength(30);
    }
}

