using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.Shipments.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.Shipments.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.Shipments.Validators;

public class CreateShipmentValidator : AbstractValidator<CreateShipmentCommand>
{
    public CreateShipmentValidator()
    {
        RuleFor(x => x.Shipment).SetValidator(new CreateShipmentDtoValidator());
    }
}
