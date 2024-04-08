using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.StockDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateDtoRootValidators.StockDtos;

public class CreateStockContainerDtoValidator : AbstractValidator<CreateStockContainerDto>
{
    public CreateStockContainerDtoValidator()
    {
        RuleFor(p => p.Sscc).NotEmpty().NotNull().MaximumLength(30);
        RuleFor(p => p.ContainerUnitId).NotEmpty().NotNull().InclusiveBetween(0, int.MaxValue);
    }
}



