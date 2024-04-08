using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateDtoRootValidators.ShipmentDtos;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentAttributeValues.Commands.Create;

namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentAttributeValues.Validators;

public class CreateShipmentAttributeValueValidator : AbstractValidator<CreateShipmentAttributeValueCommand>
{
    public CreateShipmentAttributeValueValidator()
    {
        RuleFor(x => x.ShipmentAttributeValue).SetValidator(new CreateShipmentAttributeValueDtoValidator());
    }
}
