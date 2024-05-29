using FluentValidation;

namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItmStockAttrValues.Dtos.DtoValidators;

public class UpdateReceiptItmStockAttrValueSubDtoValidator : AbstractValidator<UpdateReceiptItmStockAttrValueSubDto>
{
    public UpdateReceiptItmStockAttrValueSubDtoValidator()
    {
        RuleFor(p => p.StockAttributeId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.Value).NotEmpty().NotNull().MaximumLength(120);
    }
}


