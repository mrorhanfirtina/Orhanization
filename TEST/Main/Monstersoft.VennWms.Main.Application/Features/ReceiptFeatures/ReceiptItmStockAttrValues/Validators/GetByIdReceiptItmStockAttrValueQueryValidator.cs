using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItmStockAttrValues.Queries.GetById;

namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItmStockAttrValues.Validators;

public class GetByIdReceiptItmStockAttrValueQueryValidator : AbstractValidator<GetByIdReceiptItmStockAttrValueQuery>
{
    public GetByIdReceiptItmStockAttrValueQueryValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
