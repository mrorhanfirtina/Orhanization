using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.SubDtos.ShipmentDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateSubDtoValidators.ShipmentDtos;

public class UpdateShipmentMemoSubDtoValidator : AbstractValidator<UpdateShipmentMemoSubDto>
{
    public UpdateShipmentMemoSubDtoValidator()
    {
        RuleFor(p => p.Description).NotEmpty().NotNull().MaximumLength(50);
        RuleFor(p => p.Text).NotEmpty().NotNull().MaximumLength(500);
    }
}


