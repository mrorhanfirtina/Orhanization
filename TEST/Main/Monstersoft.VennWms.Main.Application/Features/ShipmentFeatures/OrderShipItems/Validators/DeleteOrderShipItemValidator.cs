using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItems.Commands.Delete;

namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItems.Validators;

public class DeleteOrderShipItemValidator : AbstractValidator<DeleteOrderShipItemCommand>
{
    public DeleteOrderShipItemValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
