using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateDtoRootValidators.ReceiptDtos;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItmStockAttrValues.Commands.Update;

namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItmStockAttrValues.Validators;

public class UpdateReceiptItmStockAttrValueValidator : AbstractValidator<UpdateReceiptItmStockAttrValueCommand>
{
    public UpdateReceiptItmStockAttrValueValidator()
    {
        RuleFor(x => x.ReceiptItmStockAttrValue).SetValidator(new UpdateReceiptItmStockAttrValueDtoValidator());
    }
}
