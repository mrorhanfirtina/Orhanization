using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItemMemos.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItemMemos.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItemMemos.Validators;

public class CreateOrderItemMemoValidator : AbstractValidator<CreateOrderItemMemoCommand>
{
    public CreateOrderItemMemoValidator()
    {
        RuleFor(x => x.OrderItemMemo).SetValidator(new CreateOrderItemMemoDtoValidator());
    }
}
