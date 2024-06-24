using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentTypes.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentTypes.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentTypes.Validators;

public class UpdateShipmentTypeValidator : AbstractValidator<UpdateShipmentTypeCommand>
{
    public UpdateShipmentTypeValidator()
    {
        RuleFor(x => x.ShipmentType).SetValidator(new UpdateShipmentTypeDtoValidator());
    }
}
