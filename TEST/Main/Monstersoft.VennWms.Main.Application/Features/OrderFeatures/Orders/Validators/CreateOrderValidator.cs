using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.Orders.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.Orders.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features;

public class CreateOrderValidator : AbstractValidator<CreateOrderCommand>
{
    public CreateOrderValidator()
    {
        RuleFor(x => x.Order).SetValidator(new CreateOrderDtoValidator());
    }
}
