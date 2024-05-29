using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItems.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItems.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItems.Validators;

public class UpdateOrderShipItemValidator : AbstractValidator<UpdateOrderShipItemCommand>
{
    public UpdateOrderShipItemValidator()
    {
        RuleFor(x => x.OrderShipItem).SetValidator(new UpdateOrderShipItemDtoValidator());
    }
}
