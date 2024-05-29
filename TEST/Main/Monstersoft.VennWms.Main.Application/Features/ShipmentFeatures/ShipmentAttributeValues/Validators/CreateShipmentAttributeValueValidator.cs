using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentAttributeValues.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentAttributeValues.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentAttributeValues.Validators;

public class CreateShipmentAttributeValueValidator : AbstractValidator<CreateShipmentAttributeValueCommand>
{
    public CreateShipmentAttributeValueValidator()
    {
        RuleFor(x => x.ShipmentAttributeValue).SetValidator(new CreateShipmentAttributeValueDtoValidator());
    }
}
