using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateDtoRootValidators.ShipmentDtos;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItemTasks.Commands.Update;

namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItemTasks.Validators;

public class UpdateOrderShipItemTaskValidator : AbstractValidator<UpdateOrderShipItemTaskCommand>
{
    public UpdateOrderShipItemTaskValidator()
    {
        RuleFor(x => x.OrderShipItemTask).SetValidator(new UpdateOrderShipItemTaskDtoValidator());
    }
}
