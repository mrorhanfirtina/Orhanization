using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItmStockAttrValues.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItmStockAttrValues.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItmStockAttrValues.Validators;

public class UpdateReceiptItmStockAttrValueValidator : AbstractValidator<UpdateReceiptItmStockAttrValueCommand>
{
    public UpdateReceiptItmStockAttrValueValidator()
    {
        RuleFor(x => x.ReceiptItmStockAttrValue).SetValidator(new UpdateReceiptItmStockAttrValueDtoValidator());
    }
}
