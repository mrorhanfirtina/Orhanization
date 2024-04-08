using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateDtoRootValidators.ShipmentDtos;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentMemos.Commands.Create;

namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentMemos.Validators;

public class CreateShipmentMemoValidator : AbstractValidator<CreateShipmentMemoCommand>
{
    public CreateShipmentMemoValidator()
    {
        RuleFor(x => x.ShipmentMemo).SetValidator(new CreateShipmentMemoDtoValidator());
    }
}
