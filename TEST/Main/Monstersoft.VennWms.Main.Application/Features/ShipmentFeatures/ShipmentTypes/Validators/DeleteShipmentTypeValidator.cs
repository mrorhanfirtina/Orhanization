using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentTypes.Commands.Delete;

namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentTypes.Validators;

public class DeleteShipmentTypeValidator : AbstractValidator<DeleteShipmentTypeCommand>
{
    public DeleteShipmentTypeValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
