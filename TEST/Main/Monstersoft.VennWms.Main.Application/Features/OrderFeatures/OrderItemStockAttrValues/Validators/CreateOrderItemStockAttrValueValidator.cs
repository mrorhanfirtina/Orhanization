using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItemStockAttrValues.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItemStockAttrValues.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItemStockAttrValues.Validators;

public class CreateOrderItemStockAttrValueValidator : AbstractValidator<CreateOrderItemStockAttrValueCommand>
{
    public CreateOrderItemStockAttrValueValidator()
    {
        RuleFor(x => x.OrderItemStockAttrValue).SetValidator(new CreateOrderItemStockAttrValueDtoValidator());
    }
}
