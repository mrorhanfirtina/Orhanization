using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentAttributes.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentAttributes.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentAttributes.Validators;

public class UpdateShipmentAttributeValidator : AbstractValidator<UpdateShipmentAttributeCommand>
{
    public UpdateShipmentAttributeValidator()
    {
        RuleFor(x => x.ShipmentAttribute).SetValidator(new UpdateShipmentAttributeDtoValidator());
    }
}
