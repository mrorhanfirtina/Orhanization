using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItemMemos.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItemMemos.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItemMemos.Validators;

public class UpdateOrderItemMemoValidator : AbstractValidator<UpdateOrderItemMemoCommand>
{
    public UpdateOrderItemMemoValidator()
    {
        RuleFor(x => x.OrderItemMemo).SetValidator(new UpdateOrderItemMemoDtoValidator());
    }
}
