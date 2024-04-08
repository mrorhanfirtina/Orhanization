using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItemTasks.Commands.Delete;

namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItemTasks.Validators;

public class DeleteOrderShipItemTaskValidator : AbstractValidator<DeleteOrderShipItemTaskCommand>
{
    public DeleteOrderShipItemTaskValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
