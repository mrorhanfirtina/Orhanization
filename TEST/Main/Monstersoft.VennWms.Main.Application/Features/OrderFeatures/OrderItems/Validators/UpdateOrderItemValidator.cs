using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateDtoRootValidators.OrderDtos;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItems.Commands.Update;

namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItems.Validators;

public class UpdateOrderItemValidator : AbstractValidator<UpdateOrderItemCommand>
{
    public UpdateOrderItemValidator()
    {
        RuleFor(x => x.OrderItem).SetValidator(new UpdateOrderItemDtoValidator());
    }
}
