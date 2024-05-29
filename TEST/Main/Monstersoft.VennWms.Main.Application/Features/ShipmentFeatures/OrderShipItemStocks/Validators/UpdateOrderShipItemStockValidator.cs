using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItemStocks.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItemStocks.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItemStocks.Validators;

public class UpdateOrderShipItemStockValidator : AbstractValidator<UpdateOrderShipItemStockCommand>
{
    public UpdateOrderShipItemStockValidator()
    {
        RuleFor(x => x.OrderShipItemStock).SetValidator(new UpdateOrderShipItemStockDtoValidator());
    }
}
