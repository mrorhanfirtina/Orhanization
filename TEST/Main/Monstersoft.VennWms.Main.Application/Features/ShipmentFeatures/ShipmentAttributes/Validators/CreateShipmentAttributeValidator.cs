using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateDtoRootValidators.ShipmentDtos;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentAttributes.Commands.Create;

namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentAttributes.Validators;

public class CreateShipmentAttributeValidator : AbstractValidator<CreateShipmentAttributeCommand>
{
    public CreateShipmentAttributeValidator()
    {
        RuleFor(x => x.ShipmentAttribute).SetValidator(new CreateShipmentAttributeDtoValidator());
    }
}
