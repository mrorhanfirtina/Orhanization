using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateDtoRootValidators.ShipmentDtos;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.Shipments.Commands.Create;

namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.Shipments.Validators;

public class CreateShipmentValidator : AbstractValidator<CreateShipmentCommand>
{
    public CreateShipmentValidator()
    {
        RuleFor(x => x.Shipment).SetValidator(new CreateShipmentDtoValidator());
    }
}
