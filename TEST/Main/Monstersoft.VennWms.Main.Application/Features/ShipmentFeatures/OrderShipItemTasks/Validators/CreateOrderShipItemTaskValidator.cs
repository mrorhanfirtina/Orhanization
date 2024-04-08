using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateDtoRootValidators.ShipmentDtos;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItemTasks.Commands.Create;

namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItemTasks.Validators;

public class CreateOrderShipItemTaskValidator : AbstractValidator<CreateOrderShipItemTaskCommand>
{
    public CreateOrderShipItemTaskValidator()
    {
        RuleFor(x => x.OrderShipItemTask).SetValidator(new CreateOrderShipItemTaskDtoValidator());
    }
}
