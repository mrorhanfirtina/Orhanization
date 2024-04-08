using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItems.Queries.GetById;

namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItems.Validators;

public class GetByIdReceiptItemQueryValidator : AbstractValidator<GetByIdReceiptItemQuery>
{
    public GetByIdReceiptItemQueryValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
