using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentAttributeValues.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentAttributeValues.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentAttributeValues.Validators;

public class UpdateShipmentAttributeValueValidator : AbstractValidator<UpdateShipmentAttributeValueCommand>
{
    public UpdateShipmentAttributeValueValidator()
    {
        RuleFor(x => x.ShipmentAttributeValue).SetValidator(new UpdateShipmentAttributeValueDtoValidator());
    }
}
