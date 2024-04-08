using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateDtoRootValidators.ShipmentDtos;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.Shipments.Commands.Update;

namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.Shipments.Validators;

public class UpdateShipmentValidator : AbstractValidator<UpdateShipmentCommand>
{
    public UpdateShipmentValidator()
    {
        RuleFor(x => x.Shipment).SetValidator(new UpdateShipmentDtoValidator());
    }
}
