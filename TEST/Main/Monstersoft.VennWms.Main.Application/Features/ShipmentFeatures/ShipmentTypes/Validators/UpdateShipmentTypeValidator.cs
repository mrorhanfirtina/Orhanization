using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateDtoRootValidators.ShipmentDtos;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentTypes.Commands.Update;

namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentTypes.Validators;

public class UpdateShipmentTypeValidator : AbstractValidator<UpdateShipmentTypeCommand>
{
    public UpdateShipmentTypeValidator()
    {
        RuleFor(x => x.ShipmentType).SetValidator(new UpdateShipmentTypeDtoValidator());
    }
}
