using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItemStocks.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItemStocks.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItemStocks.Validators;

public class CreateOrderShipItemStockValidator : AbstractValidator<CreateOrderShipItemStockCommand>
{
    public CreateOrderShipItemStockValidator()
    {
        RuleFor(x => x.OrderShipItemStock).SetValidator(new CreateOrderShipItemStockDtoValidator());
    }
}
