using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItemTasks.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItemTasks.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItemTasks.Validators;

public class UpdateOrderShipItemTaskValidator : AbstractValidator<UpdateOrderShipItemTaskCommand>
{
    public UpdateOrderShipItemTaskValidator()
    {
        RuleFor(x => x.OrderShipItemTask).SetValidator(new UpdateOrderShipItemTaskDtoValidator());
    }
}
