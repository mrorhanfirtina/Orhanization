using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptAttributes.Queries.GetById;

namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptAttributes.Validators;

public class GetByIdReceiptAttributeQueryValidator : AbstractValidator<GetByIdReceiptAttributeQuery>
{
    public GetByIdReceiptAttributeQueryValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
