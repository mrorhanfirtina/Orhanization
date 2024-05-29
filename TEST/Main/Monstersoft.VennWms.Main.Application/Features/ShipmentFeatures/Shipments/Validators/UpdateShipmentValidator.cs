using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.Shipments.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.Shipments.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.Shipments.Validators;

public class UpdateShipmentValidator : AbstractValidator<UpdateShipmentCommand>
{
    public UpdateShipmentValidator()
    {
        RuleFor(x => x.Shipment).SetValidator(new UpdateShipmentDtoValidator());
    }
}
