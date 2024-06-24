using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItems.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItems.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItems.Validators;

public class UpdateOrderItemValidator : AbstractValidator<UpdateOrderItemCommand>
{
    public UpdateOrderItemValidator()
    {
        RuleFor(x => x.OrderItem).SetValidator(new UpdateOrderItemDtoValidator());
    }
}
