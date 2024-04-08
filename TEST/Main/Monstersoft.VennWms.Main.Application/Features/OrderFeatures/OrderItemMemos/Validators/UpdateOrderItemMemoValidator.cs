using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateDtoRootValidators.OrderDtos;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItemMemos.Commands.Update;

namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItemMemos.Validators;

public class UpdateOrderItemMemoValidator : AbstractValidator<UpdateOrderItemMemoCommand>
{
    public UpdateOrderItemMemoValidator()
    {
        RuleFor(x => x.OrderItemMemo).SetValidator(new UpdateOrderItemMemoDtoValidator());
    }
}
