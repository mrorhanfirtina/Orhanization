using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateDtoRootValidators.StockDtos;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainers.Commands.Update;

namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainers.Validators;

public class UpdateStockContainerValidator : AbstractValidator<UpdateStockContainerCommand>
{
    public UpdateStockContainerValidator()
    {
        RuleFor(x => x.StockContainer).SetValidator(new UpdateStockContainerDtoValidator());
    }
}
