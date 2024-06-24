using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItems.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItems.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItems.Validators;

public class CreateOrderShipItemValidator : AbstractValidator<CreateOrderShipItemCommand>
{
    public CreateOrderShipItemValidator()
    {
        RuleFor(x => x.OrderShipItem).SetValidator(new CreateOrderShipItemDtoValidator());
    }
}
