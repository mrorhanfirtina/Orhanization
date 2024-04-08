using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.SubDtos.ShipmentDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateSubDtoValidators.ShipmentDtos;

public class CreateShipmentMemoSubDtoValidator : AbstractValidator<CreateShipmentMemoSubDto>
{
    public CreateShipmentMemoSubDtoValidator()
    {
        RuleFor(p => p.Description).NotEmpty().NotNull().MaximumLength(50);
        RuleFor(p => p.Text).NotEmpty().NotNull().MaximumLength(500);
    }
}


