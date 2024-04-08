using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateDtoRootValidators.OrderDtos;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItemStockAttrValues.Commands.Update;

namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItemStockAttrValues.Validators;

public class UpdateOrderItemStockAttrValueValidator : AbstractValidator<UpdateOrderItemStockAttrValueCommand>
{
    public UpdateOrderItemStockAttrValueValidator()
    {
        RuleFor(x => x.OrderItemStockAttrValue).SetValidator(new UpdateOrderItemStockAttrValueDtoValidator());
    }
}
