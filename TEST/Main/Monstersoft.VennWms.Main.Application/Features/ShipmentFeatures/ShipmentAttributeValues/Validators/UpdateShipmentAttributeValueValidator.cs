using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateDtoRootValidators.ShipmentDtos;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentAttributeValues.Commands.Update;

namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentAttributeValues.Validators;

public class UpdateShipmentAttributeValueValidator : AbstractValidator<UpdateShipmentAttributeValueCommand>
{
    public UpdateShipmentAttributeValueValidator()
    {
        RuleFor(x => x.ShipmentAttributeValue).SetValidator(new UpdateShipmentAttributeValueDtoValidator());
    }
}
