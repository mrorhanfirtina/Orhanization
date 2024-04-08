using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.SubDtos.StockDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateSubDtoValidators.StockDtos;

public class UpdateStockContainerSubDtoValidator : AbstractValidator<UpdateStockContainerSubDto>
{
    public UpdateStockContainerSubDtoValidator()
    {
        RuleFor(p => p.Sscc).NotEmpty().NotNull().MaximumLength(30);
        RuleFor(p => p.ContainerUnitId).NotEmpty().NotNull().InclusiveBetween(0, int.MaxValue);
    }
}


