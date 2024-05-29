using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentMemos.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentMemos.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentMemos.Validators;

public class CreateShipmentMemoValidator : AbstractValidator<CreateShipmentMemoCommand>
{
    public CreateShipmentMemoValidator()
    {
        RuleFor(x => x.ShipmentMemo).SetValidator(new CreateShipmentMemoDtoValidator());
    }
}
