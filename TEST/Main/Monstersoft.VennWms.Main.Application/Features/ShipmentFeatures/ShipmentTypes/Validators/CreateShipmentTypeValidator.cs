using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentTypes.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentTypes.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentTypes.Validators;

public class CreateShipmentTypeValidator : AbstractValidator<CreateShipmentTypeCommand>
{
    public CreateShipmentTypeValidator()
    {
        RuleFor(x => x.ShipmentType).SetValidator(new CreateShipmentTypeDtoValidator());
    }
}
