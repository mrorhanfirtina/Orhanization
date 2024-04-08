using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateDtoRootValidators.ShipmentDtos;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItems.Commands.Update;

namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItems.Validators;

public class UpdateOrderShipItemValidator : AbstractValidator<UpdateOrderShipItemCommand>
{
    public UpdateOrderShipItemValidator()
    {
        RuleFor(x => x.OrderShipItem).SetValidator(new UpdateOrderShipItemDtoValidator());
    }
}
