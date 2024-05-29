using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.Orders.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.Orders.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features;

public class UpdateOrderValidator : AbstractValidator<UpdateOrderCommand>
{
    public UpdateOrderValidator()
    {
        RuleFor(x => x.Order).SetValidator(new UpdateOrderDtoValidator());
    }
}
