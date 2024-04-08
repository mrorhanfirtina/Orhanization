using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateDtoRootValidators.ShipmentDtos;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItemStocks.Commands.Update;

namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItemStocks.Validators;

public class UpdateOrderShipItemStockValidator : AbstractValidator<UpdateOrderShipItemStockCommand>
{
    public UpdateOrderShipItemStockValidator()
    {
        RuleFor(x => x.OrderShipItemStock).SetValidator(new UpdateOrderShipItemStockDtoValidator());
    }
}
