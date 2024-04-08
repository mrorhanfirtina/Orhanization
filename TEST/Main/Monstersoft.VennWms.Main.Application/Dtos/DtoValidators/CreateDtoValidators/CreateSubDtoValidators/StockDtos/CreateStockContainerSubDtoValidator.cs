using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.SubDtos.StockDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateSubDtoValidators.StockDtos;

public class CreateStockContainerSubDtoValidator : AbstractValidator<CreateStockContainerSubDto>
{
    public CreateStockContainerSubDtoValidator()
    {
        RuleFor(p => p.Sscc).NotEmpty().NotNull().MaximumLength(30);
        RuleFor(p => p.ContainerUnitId).NotEmpty().NotEmpty().NotNull().InclusiveBetween(0, int.MaxValue);
    }
}


