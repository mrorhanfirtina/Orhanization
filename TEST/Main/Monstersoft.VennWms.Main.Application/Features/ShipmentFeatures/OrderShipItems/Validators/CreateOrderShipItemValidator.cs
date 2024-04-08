using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateDtoRootValidators.ShipmentDtos;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItems.Commands.Create;

namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItems.Validators;

public class CreateOrderShipItemValidator : AbstractValidator<CreateOrderShipItemCommand>
{
    public CreateOrderShipItemValidator()
    {
        RuleFor(x => x.OrderShipItem).SetValidator(new CreateOrderShipItemDtoValidator());
    }
}
