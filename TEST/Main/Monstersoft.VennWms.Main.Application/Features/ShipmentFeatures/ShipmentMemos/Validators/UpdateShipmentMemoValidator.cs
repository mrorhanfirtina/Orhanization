using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentMemos.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentMemos.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentMemos.Validators;

public class UpdateShipmentMemoValidator : AbstractValidator<UpdateShipmentMemoCommand>
{
    public UpdateShipmentMemoValidator()
    {
        RuleFor(x => x.ShipmentMemo).SetValidator(new UpdateShipmentMemoDtoValidator());
    }
}
