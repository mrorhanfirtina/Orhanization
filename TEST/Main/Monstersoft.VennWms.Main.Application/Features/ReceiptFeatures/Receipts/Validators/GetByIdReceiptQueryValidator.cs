using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.Receipts.Queries.GetById;

namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.Receipts.Validators;

public class GetByIdReceiptQueryValidator : AbstractValidator<GetByIdReceiptQuery>
{
    public GetByIdReceiptQueryValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
