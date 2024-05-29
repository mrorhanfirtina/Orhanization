using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipments.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipments.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipments.Validators;

public class UpdateOrderShipmentValidator : AbstractValidator<UpdateOrderShipmentCommand>
{
    public UpdateOrderShipmentValidator()
    {
        RuleFor(x => x.OrderShipment).SetValidator(new UpdateOrderShipmentDtoValidator());
    }
}
