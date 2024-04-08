using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipments.Commands.Delete;

namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipments.Validators;

public class DeleteOrderShipmentValidator : AbstractValidator<DeleteOrderShipmentCommand>
{
    public DeleteOrderShipmentValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
