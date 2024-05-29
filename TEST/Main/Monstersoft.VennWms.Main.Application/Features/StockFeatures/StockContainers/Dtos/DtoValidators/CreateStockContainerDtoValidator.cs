using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainers.Dtos.CreateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainers.Dtos.DtoValidators;

public class CreateStockContainerDtoValidator : AbstractValidator<CreateStockContainerDto>
{
    public CreateStockContainerDtoValidator()
    {
        RuleFor(p => p.Sscc).NotEmpty().NotNull().MaximumLength(30);
        RuleFor(p => p.ContainerUnitId).NotEmpty().NotNull().InclusiveBetween(0, int.MaxValue);
    }
}



