using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateDtoRootValidators.ReceiptDtos;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItmStockAttrValues.Commands.Create;

namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItmStockAttrValues.Validators;

public class CreateReceiptItmStockAttrValueValidator : AbstractValidator<CreateReceiptItmStockAttrValueCommand>
{
    public CreateReceiptItmStockAttrValueValidator()
    {
        RuleFor(x => x.ReceiptItmStockAttrValue).SetValidator(new CreateReceiptItmStockAttrValueDtoValidator());
    }
}
