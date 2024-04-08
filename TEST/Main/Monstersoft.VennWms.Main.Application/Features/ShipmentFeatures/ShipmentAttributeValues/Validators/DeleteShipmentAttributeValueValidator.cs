using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentAttributeValues.Commands.Delete;

namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentAttributeValues.Validators;

public class DeleteShipmentAttributeValueValidator : AbstractValidator<DeleteShipmentAttributeValueCommand>
{
    public DeleteShipmentAttributeValueValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
