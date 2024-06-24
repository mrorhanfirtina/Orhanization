using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItemTasks.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItemTasks.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItemTasks.Validators;

public class CreateOrderShipItemTaskValidator : AbstractValidator<CreateOrderShipItemTaskCommand>
{
    public CreateOrderShipItemTaskValidator()
    {
        RuleFor(x => x.OrderShipItemTask).SetValidator(new CreateOrderShipItemTaskDtoValidator());
    }
}
