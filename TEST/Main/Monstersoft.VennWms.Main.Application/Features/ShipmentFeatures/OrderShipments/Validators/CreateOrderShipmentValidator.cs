using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateDtoRootValidators.ShipmentDtos;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipments.Commands.Create;

namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipments.Validators;

public class CreateOrderShipmentValidator : AbstractValidator<CreateOrderShipmentCommand>
{
    public CreateOrderShipmentValidator()
    {
        RuleFor(x => x.OrderShipment).SetValidator(new CreateOrderShipmentDtoValidator());
    }
}
