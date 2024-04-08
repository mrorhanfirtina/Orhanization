using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateDtoRootValidators.ShipmentDtos;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentAttributes.Commands.Update;

namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentAttributes.Validators;

public class UpdateShipmentAttributeValidator : AbstractValidator<UpdateShipmentAttributeCommand>
{
    public UpdateShipmentAttributeValidator()
    {
        RuleFor(x => x.ShipmentAttribute).SetValidator(new UpdateShipmentAttributeDtoValidator());
    }
}
