using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItemStockAttrValues.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItemStockAttrValues.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItemStockAttrValues.Validators;

public class UpdateOrderItemStockAttrValueValidator : AbstractValidator<UpdateOrderItemStockAttrValueCommand>
{
    public UpdateOrderItemStockAttrValueValidator()
    {
        RuleFor(x => x.OrderItemStockAttrValue).SetValidator(new UpdateOrderItemStockAttrValueDtoValidator());
    }
}
