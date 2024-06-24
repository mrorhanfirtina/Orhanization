using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItems.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItems.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItems.Validators;

public class CreateOrderItemValidator : AbstractValidator<CreateOrderItemCommand>
{
    public CreateOrderItemValidator()
    {
        RuleFor(x => x.OrderItem).SetValidator(new CreateOrderItemDtoValidator());
    }
}
