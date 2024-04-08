using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateDtoRootValidators.ShipmentDtos;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItemStocks.Commands.Create;

namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItemStocks.Validators;

public class CreateOrderShipItemStockValidator : AbstractValidator<CreateOrderShipItemStockCommand>
{
    public CreateOrderShipItemStockValidator()
    {
        RuleFor(x => x.OrderShipItemStock).SetValidator(new CreateOrderShipItemStockDtoValidator());
    }
}
