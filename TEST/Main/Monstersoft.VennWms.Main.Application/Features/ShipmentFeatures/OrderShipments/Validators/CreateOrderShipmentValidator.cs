using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipments.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipments.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipments.Validators;

public class CreateOrderShipmentValidator : AbstractValidator<CreateOrderShipmentCommand>
{
    public CreateOrderShipmentValidator()
    {
        RuleFor(x => x.OrderShipment).SetValidator(new CreateOrderShipmentDtoValidator());
    }
}
