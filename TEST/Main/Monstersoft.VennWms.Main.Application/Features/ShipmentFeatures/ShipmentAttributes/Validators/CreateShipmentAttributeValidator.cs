using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentAttributes.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentAttributes.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentAttributes.Validators;

public class CreateShipmentAttributeValidator : AbstractValidator<CreateShipmentAttributeCommand>
{
    public CreateShipmentAttributeValidator()
    {
        RuleFor(x => x.ShipmentAttribute).SetValidator(new CreateShipmentAttributeDtoValidator());
    }
}
